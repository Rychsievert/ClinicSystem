using Clinic.Application_Tier;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic.Presentation_Tier
{
    // Control class for the employee form.
    public partial class EmployeeForm : Form
    {
        private DBmanager dbm;
        private DataTable dataTable;
        private Login loginForm;
        private DeleteAppointment delete;
        private UndoRedo undoRedo = new UndoRedo();

        // Parameratized contructor to set the default values of the employee form.
        public EmployeeForm(Login loginForm, DBmanager dbm)
        {
            this.dbm = dbm;
            InitializeComponent();
            this.loginForm = loginForm;
            dataTable = dbm.FillAppointmentTable();
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }

        // When a user clicks a date on the calendar, show only the appointments taking place on that date.
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = Appt_Calender.SelectionRange.Start;

            // call for the database to return all appointment data occuring on the selected day and store it in a DataTable.
            dataTable = dbm.FillAppointmentTableDate(date);

            // Point the datagridview's data source to the datatable returned by the database manager with the relevant appointment information.
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }

        // search for patient(s) by name
        private void patientSearch_Click(object sender, EventArgs e)
        {
            string firstName = SearchFNameTextBox.Text;
            string lastName = SearchLNameTextBox.Text;

            // Display the first and last name from the database to the listBox1 (Appointment_List)
            dataTable = dbm.displayPatients(firstName, lastName);
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }

        // Fills the datagridview with all appointment information
        private void refreshAppointmentsButton_Click(object sender, EventArgs e)
        {
            dataTable = dbm.FillAppointmentTable();
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }

        // Displays information of all patients in the database
        private void displayAllPatientInfo_Click(object sender, EventArgs e)
        {
            dataTable = dbm.displayAllPatients();
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }

        // Delete the selected appointment and update the data grid view
        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            if (AppointmentView.SelectedRows.Count != 0)
            {
                int appointmentID = (int)AppointmentView.CurrentRow.Cells["Appointment ID"].Value;

                delete = new DeleteAppointment(dbm.getAppointmentFromID(appointmentID));
                delete.execute();
                undoRedo.InsertUndoRedo(delete);

                dataTable = dbm.FillAppointmentTable();
                AppointmentView.DataSource = dataTable;
                AppointmentView.DataMember = dataTable.TableName;
            }
        }

        // returns the user to the login screen
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        // Changes the style of the form to light mode from dark mode or vice versa.
        private void themeButton_Click(object sender, EventArgs e)
        {
            if (themeButton.Text == "Switch to Dark Theme")
            {
                themeButton.Text = "Switch to Light Theme";
                this.BackColor = Color.DarkGray;                // sets the form background color to dark gray
                Appt_Calender.BackColor = Color.BlueViolet;
            }
            else
            {
                themeButton.Text = "Switch to Dark Theme";
                this.BackColor = Color.LightYellow;
            }
        }

        // Undo the most recent deletion of an appointment
        private void undoDeleteButton_Click(object sender, EventArgs e)
        {
            undoRedo.Undo();
            dataTable = dbm.FillAppointmentTable();
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }

        // If an appointment deletion was undone, redelete the most recent.
        private void redoDeleteButton_Click(object sender, EventArgs e)
        {
            undoRedo.Redo();
            dataTable = dbm.FillAppointmentTable();
            AppointmentView.DataSource = dataTable;
            AppointmentView.DataMember = dataTable.TableName;
        }
    }
}
