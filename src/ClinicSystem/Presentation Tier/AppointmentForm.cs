using Clinic.Application_Tier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;


namespace Clinic.Presentation_Tier
{
    // Controls the form associated with appointments
    public partial class AppointmentForm : Form
    {
        private Login loginForm;
        private DBmanager dbm;
        private ClinicSystem clinicSystem = ClinicSystem.getInstance();
        private int patientID;
        private int appointment_id;
        private string patientUsername;
        private Connection connection;
        private MySqlConnection con;
        private List<string> timeList;
        private int employee_id;
        private Appointment appointment;
        private InsertAppointment insert;
        private UndoRedo undoRedo;

        // Paramatized constructor that created the default values for the appointment form.
        public AppointmentForm(Login loginForm, DBmanager dbm, string username)
        {
            this.loginForm = loginForm;
            this.dbm = dbm;
            this.patientUsername = username;
            this.patientID = dbm.getID(username);
            InitializeComponent();
            this.connection = new Connection();
            this.con = new MySqlConnection(connection.ToString());
            timeList = new List<string>();
            fillTimes(timeList);
            comboBox1.DataSource = timeList;
            undoRedo = new UndoRedo();
            data();

            if (dbm.getOptOutEmail(this.patientID) == 1)
            {
                this.label6.Text = "Not recieving automated emails";
            }
        }

        // Add appointment button event handler. 
        // Creates a new appointment with the given parameters
        private void AddAppointment_Click(object sender, EventArgs e)
        {
            int doctor_id = employee_id;
            int illness_id = Convert.ToInt32(comboBox2.SelectedValue);
            string date = App_Calender.Value.ToString("yyyy-MM-dd") + " " + (DateTime.ParseExact(comboBox1.Text, "hh:mm tt", CultureInfo.InvariantCulture)).ToString("HH:mm:ss");
            appointment = new Appointment(clinicSystem.GetPatient().getID(), doctor_id, illness_id, date);

            insert = new InsertAppointment(appointment);
            insert.execute();
            undoRedo.InsertUndoRedo(insert);

            data();
            
            displayErrorMessage(confirmationLabel, "Appointment Added");
        }

        // Load the appointments form.
        // Displays the appointments for the employee to see.
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader reader;

            con.Open();
            string query = "SELECT id,first_name FROM person where is_employee=1";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employee_id = Convert.ToInt32(reader["id"]);
                textBox2.Text = reader["first_name"].ToString();
            }

            con.Close();

            con.Open();

            MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT illness_id,illness_name FROM illness", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "illness_name";
            comboBox2.ValueMember = "illness_id";

            con.Close();

        }

        // Event handler to display the current appointments
        private void displayAppointmentsButton(object sender, EventArgs e)
        {
            data();
        }

        // Event handler for the datagrid view of appointments. 
        // Holds the selectable contents of appointments
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = appointmentGrid.Rows[e.RowIndex];
                checkInStatusList.Text = row.Cells["Check-in Status"].Value.ToString();
                appointment_id = Convert.ToInt32(row.Cells["Appointment ID"].Value);
            }
        }

        // Sets the appointment grid's data source to the source on the data base.
        public void data()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT appointment.id AS 'Appointment ID', person.first_name AS 'Doctor'," +
                " illness.illness_name AS 'Symptoms', appointment.time AS 'Appointment Time', appointment.check_in_status AS " +
                "'Check-in Status' FROM `appointment` join person on appointment.doctor_person_id=person.id join illness on illness.illness_id=appointment.illness_id where " +
                "appointment.patient_person_id=" + patientID + " order by time", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            appointmentGrid.DataSource = dt;
        }

        // Handles the event of when the update check in status button is clicked
        private void CheckInStatus_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            con.Open();
            cmd = new MySqlCommand("update appointment Set check_in_status='" + checkInStatusList.Text + "' where id=" + appointment_id, con);
            cmd.ExecuteNonQuery();
            con.Close();
            data();
        }

        // Handles the event of when the user clicks the opt in/out of emails.
        private void optInOutEmails_Click(object sender, EventArgs e)
        {
            int val = (dbm.getOptOutEmail(this.patientID) == 0) ? 1 : 0;
            MySqlCommand cmd;
            con.Open();
            cmd = new MySqlCommand("update person Set opt_out_email=" + val + " where id=" + this.patientID, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.label6.Text = (dbm.getOptOutEmail(this.patientID) == 0) ? "Recieving automated emails" : "Not recieving automated emails";
        }

        // Event handler to log out of the current account.
        // Closes the current form and shows the login form.
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        // Displays error messages based on given parameters
        private void displayErrorMessage(Label errorlabel, string message)
        {
            errorlabel.Text = message;

            var t = new Timer();
            t.Interval = 5000;
            t.Tick += (s, f) =>
            {
                errorlabel.Visible = false;
                t.Stop();
            };
            t.Start();
            errorlabel.Visible = true;
        }

        // Sets the times available in the appointment time list.
        public void fillTimes(List<string> list)
        {
            list.Add(DateTime.Parse("07:00:00 AM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("08:00:00 AM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("09:00:00 AM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("10:00:00 AM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("11:00:00 AM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("12:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("01:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("02:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("03:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("04:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("05:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("06:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("07:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("08:00:00 PM").ToString("hh:mm tt"));
            list.Add(DateTime.Parse("09:00:00 PM").ToString("hh:mm tt"));
        }

        // Undoes the last entered appointment.
        private void undoAppointmentButton_Click(object sender, EventArgs e)
        {
            undoRedo.Undo();
            data();
        }

        // Redoes the last deleted appointment.
        private void redoAppointmentButton_Click(object sender, EventArgs e)
        {
            undoRedo.Redo();
            data();
        }
    }
}
