using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Clinic
{
    // The base driver class associated with the WinForms project.
    static class Program
    {
        private static System.Timers.Timer emailTimer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            emailTimer = new System.Timers.Timer();
            //emailTimer.Interval = 86400000; //One day
            emailTimer.Interval = 3600000; //One Hour
            emailTimer.Elapsed += reminderEmail;
            emailTimer.AutoReset = true;
            emailTimer.Enabled = true;
        }

        // Calls EmailManager's sendReminders
        private static void reminderEmail(Object source, System.Timers.ElapsedEventArgs e)
        {
            EmailManager em = new EmailManager();
            em.sendReminders();
        }
    }
}
