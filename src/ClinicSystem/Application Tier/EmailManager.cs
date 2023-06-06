using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Data;

namespace Clinic
{
    // Manages what is sent to specific emails.
    public class EmailManager
    {
        private SmtpClient SmtpServer;
        private DBmanager dm;

        // Default constructor to set port, credentials, and creating new SmtpClient and DBManager.
        public EmailManager()
        {
            SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("se3330nullpointerexception@gmail.com", "hlmrrljdsc5!");
            SmtpServer.EnableSsl = true;
            dm = new DBmanager();
        }

        // Sends mails to the specified location with the given subject and body.
        public int sendMail(string destination, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("se3330nullpointerexception@gmail.com");
                mail.To.Add(destination);
                mail.Subject = subject;
                mail.Body = body;
                SmtpServer.Send(mail);

                return 1;
            }
            catch
            {
                return -1;
            }
        }

        // Sends reminders to emails of those who have not opted out.
        public void sendReminders()
        {
            DataTable dataTable = dm.getTimeEmailDay();
            DataRow[] rows = dataTable.Select(null, null, DataViewRowState.CurrentRows);
            string destination;
            string body;

            foreach (DataRow row in rows)
            {
                if ((int)row["opt_out_email"] == 0)
                {
                    destination = (string)row["Email"];
                    body = "This is an automated message\n\n" + (string)row["First Name"] + " " + (string)row["Last Name"]
                       + " has an appointment at " + (string)row["Time"];
                    sendMail(destination, "Upcoming Appointment", body);
                }
            }

            dataTable = dm.getTimeEmailMissed();
            rows = dataTable.Select(null, null, DataViewRowState.CurrentRows);

            foreach (DataRow row in rows)
            {
                if ((int)row["opt_out_email"] == 0)
                {
                    destination = (string)row["Email"];
                    body = "This is an automated message\n\n" + (string)row["First Name"] + " " + (string)row["Last Name"]
                      + " has missed an appointment that was supposed to occur at " + (string)row["Time"];
                    sendMail(destination, "Missed Appointment", body);
                }
            }
        }
        
        //When inputChoice == 1, input should be the username
        //     Otherwise, input should be the email
        public void sendPassword(int inputChoice, string input)
        {
            string email = input;

            if (inputChoice == 1)
                email = dm.getEmail(input);

            string password = dm.recoverPassword(inputChoice, input);

            sendMail(email, "Mercy Clinic account password recovery", "A password recovery was requested for this email address, if you did not request this"
                    + " please contact our security team.\n\nYour password: " + password);
        }

        //-------------------------------------------------------
        // DO WE NEED THIS? WE HAVE NO REFERENCES TO IT
        //-------------------------------------------------------
        public Boolean emailAccountCreation(string email)
        {
            try
            {
                /*
                 MailMessage mail = new MailMessage();
                 SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                 mail.From = new MailAddress("se3330nullpointerexception@gmail.com");
                 mail.To.Add(email);
                 mail.Subject = "Thank you for creating an account";
                 mail.Body = "Thank you for creating an account with our clinic system";

                 SmtpServer.Port = 587;
                 SmtpServer.Credentials = new System.Net.NetworkCredential("se3330nullpointerexception@gmail.com", "hlmrrljdsc5!");
                 SmtpServer.EnableSsl = true;

                 SmtpServer.Send(mail);
                */
                string subject = "Thank you for creating an account";
                string body = "Thank you for creating an account with our clinic system";
                sendMail(email, subject, body);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}