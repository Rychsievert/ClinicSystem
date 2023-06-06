using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic
{
    /*
     * This class handles most of the methods that connect to the database to insert information or receive it.
     */
    public class DBmanager
    {
        private ClinicSystem clinicSystem = ClinicSystem.getInstance(); // Gets the instance of the the Clinic System.
        private Connection con = new Connection();                      // Creates a new connection
        private MySqlConnection conn;                                   // Creates a new MySqlConnection

        // Default constructor
        // Sets the MySqlConnection to the new Connection
        public DBmanager()
        {
            conn = new MySqlConnection(con.ToString());
        }

        // Receives an Appointment object and dissects its information to add it into the database in the appointment table
        // In this method the "id" value is handled by the database as it is auto-incremented for ease of use.
        public void AddAppointment(Appointment appointment)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd;

                cmd = new MySqlCommand("insert into appointment (time,doctor_person_id,patient_person_id,illness_id,check_in_status) " +
                                       "value('" + appointment.getDate() + "'," + appointment.getEmployeeID() + "," + appointment.getPatientID() 
                                       + "," + appointment.getIllnessID() + ",'Not Checked In')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        // This method takes an Appointment object and adds its data to the database same as the above method.
        // However, this one allows a specific "id" value for the appointment to be used. This is so that if 
        // an appointment is deleted and then re-added it can retain its original id.
        public void AddAppointmentWithID(Appointment appointment, int id)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd;

                cmd = new MySqlCommand("insert into appointment value(" + id + ", '" + appointment.getDate() + "'," + appointment.getEmployeeID() + "," + appointment.getPatientID() + "," + appointment.getIllnessID() + ",'Not Checked In')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        // Called after the create account GUI is used on the login screen to add a new person to the database. 
        // Is passed a Person object and dissects its information to pass to the database to add a new row to the person table.
        public void AddPerson(Person person)
        {
            try
            {
                con.Open();
                MySqlDataReader reader;
                string query = "INSERT INTO person (first_name, last_name, age, username, password, email, is_employee) VALUES ('" +
                                person.getFName() + "', '" + person.getLName() + "', " + person.getAge() + ", '" + person.getUsername() + "', '" + 
                                person.getPassword() + "', '" + person.getEmail() + "', " + person.getIsEmployee() + ");";

                reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                }
                con.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        //-----------------------------------------------------------------------------------------------------------
        // DO WE NEED THIS? THERE ARE NO REFERENCES TO IT
        //-----------------------------------------------------------------------------------------------------------
        public void SetPatient(string username)
        {
            string name = "";
            string email = "";
            con.Open();
            MySqlDataReader reader;
            string query = "SELECT first_name, last_name, email FROM person WHERE username = '" + username + "';";

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                name = (reader["first_name"].ToString() + " " + reader["last_name"].ToString());
                email = reader["email"].ToString();
            }
            con.Close();

            clinicSystem.SetPatient(username, getID(username));
        }

        // Remove the row in the person table from the database that contains the unique username provided
        public void DeleteAccount(string username)
        {
            try
            {
                con.Open();
                MySqlDataReader reader;
                string query = "DELETE FROM person WHERE username = '" + username + "';";

                reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                }

                con.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        // Determines if a user is an employee or a patient when logging in.
        // Whether the user credentials exist has already been taken care of, all this method returns is
        // a reference to whether the patient screen or employee screen needs to be shown following the log in.
        public int LoginUser(string username, string password)
        {
            int isEmployee = -1;

            try
            {
                con.Open();
                string query = "SELECT is_employee FROM person WHERE username ='" + username + "' AND password ='" + password + "'";
                MySqlDataReader reader;
                reader = con.ExecuteReader(query);

                while (reader.Read())
                {
                    isEmployee = Int16.Parse(reader["is_employee"].ToString());
                }

                if (isEmployee == 0)
                {
                    clinicSystem.SetPatient(username, getID(username));
                    return isEmployee;
                }
                else if (isEmployee == 1)
                {
                    clinicSystem.SetEmployee(username, getID(username));
                    return isEmployee;
                }
                else
                    return isEmployee;
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        // Returns a DataTable to fill the datagridview on the employee form with data of all the appointments in the database
        public DataTable FillAppointmentTable()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();

            try
            {
                string sql =

                    "SELECT appointment.id AS 'Appointment ID', time AS 'Time', check_in_status AS 'Check-In Status', P1.first_name AS 'Patient First Name', P1.last_name AS 'Patient Last Name', P2.last_name AS 'Doctor', illness.illness_name AS 'Reason for Visit'\n"
                    + "FROM (appointment\nJOIN patient\nON appointment.patient_person_id = patient.person_id\nJOIN person P1\nON patient.person_id = P1.id\n"
                    + "JOIN doctor\nON appointment.doctor_person_id = doctor.person_id\nJOIN person P2\nON doctor.person_id = P2.id)\n"
                    + "JOIN illness\nON appointment.illness_id = illness.illness_id\n"
                    + "ORDER BY time ASC;";

                conn = new MySqlConnection(con.ToString());
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        // Returns a DataTable to fill the datagridview on the employee form with all the data of appointments taking place on the selected date.
        public DataTable FillAppointmentTableDate(DateTime date)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();

            try
            {
                string sql =

                    "SELECT appointment.id AS 'Appointment ID', time AS 'Time', check_in_status AS 'Check-In Status', P1.first_name AS 'Patient First Name', P1.last_name AS 'Patient Last Name', P2.last_name AS 'Doctor', illness.illness_name AS 'Reason for Visit'\n"
                    + "FROM (appointment\nJOIN patient\nON appointment.patient_person_id = patient.person_id\nJOIN person P1\nON patient.person_id = P1.id\n"
                    + "JOIN doctor\nON appointment.doctor_person_id = doctor.person_id\nJOIN person P2\nON doctor.person_id = P2.id)\n"
                    + "JOIN illness\nON appointment.illness_id = illness.illness_id\n"
                    + "WHERE YEAR(time) = " + date.Year + " AND MONTH(time) = " + date.Month + " AND DAY(time) = " + date.Day
                    + "\nORDER BY time ASC;";

                conn = new MySqlConnection(con.ToString());
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        // Returns a DataTable to fill the datagridview on the employee form with information of patients in the database
        // who have the specified name(s)
        public DataTable displayPatients(string fname, string lname)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();
            string sql;

            try
            {
                // If only the first name has been specified
                if (lname == "" && fname != "")
                {
                    sql = "SELECT first_name AS 'First Name', last_name AS 'Last Name', age AS 'Age', email AS 'Email'"
                                 + "\nFROM person \nWHERE first_name = '" + fname + "' AND is_employee = 0 \nORDER BY last_name ASC;";

                }
                // If only the last name has been specified
                else if (fname == "" && lname != "")
                {
                    sql = "SELECT first_name AS 'First Name', last_name AS 'Last Name', age AS 'Age', email AS 'Email'"
                                 + "\nFROM person \nWHERE last_name = '" + lname + "' AND is_employee = 0 \nORDER BY last_name ASC;";
                }
                // If both first and last name have been specified
                else
                {
                    sql = "SELECT first_name AS 'First Name', last_name AS 'Last Name', age AS 'Age', email AS 'Email'"
                                 + "\nFROM person \nWHERE first_name = '" + fname + "' AND last_name = + '" + lname + "' AND is_employee = 0 \nORDER BY last_name ASC;";
                }

                conn = new MySqlConnection(con.ToString());
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        // Returns a DataTable used to fill the datagridview on the employee form with information of all patients in the database
        public DataTable displayAllPatients()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();
            string sql;

            try
            {
                sql = "SELECT first_name AS 'First Name', last_name AS 'Last Name', age AS 'Age', email AS 'Email'"
                                 + "\nFROM person \nWHERE is_employee = 0 \nORDER BY last_name ASC;";

                conn = new MySqlConnection(con.ToString());
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        // Is passed an appointment object and determines the id paired with it so that its data can be removed from the database
        public void deleteAppointment(Appointment appointment)
        {
            int id = getAppointmentID(appointment);

            try
            {
                con.Open();
                MySqlDataReader reader;
                string query = "DELETE FROM appointment WHERE id = " + id + ";";

                reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fills a newly created dataTable with the appointment data table.
        // Returns the newly filled table to the datagridview on the form.
        public DataTable getTimeEmailDay()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();
            string sql;

            try
            {
                sql = "SELECT first_name AS 'First Name', last_name AS 'Last Name', email AS 'Email', time AS 'Time'"
                           + "\nFROM person"
                           + "\nINNER JOIN patient ON patient.person_id = person.id"
                           + "\nINNER JOIN appointment ON patient.person_id = appointment.patient_person_id"
                           + "\nWHERE Time < DATE_ADD(NOW(), INTERVAL 1 DAY) &&"
                           + "Time >= DATE_ADD(DATE_SUB(NOW(), INTERVAL 1 HOUR), INTERVAL 1 DAY);";

                conn = new MySqlConnection(con.ToString());
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        // Fills a newly created dataTable with the missed appointment data table.
        // Returns the newly filled table to the datagridview on the form.
        public DataTable getTimeEmailMissed()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            DataTable dataTable = new DataTable();
            string sql;

            try
            {
                sql = "SELECT first_name AS 'First Name', last_name AS 'Last Name', email AS 'Email', time AS 'Time'"
                           + "\nFROM person"
                           + "\nINNER JOIN patient ON patient.person_id = person.id"
                           + "\nINNER JOIN appointment ON patient.person_id = appointment.patient_person_id"
                           + "\nWHERE Time < DATE_ADD(NOW(), INTERVAL 1 HOUR) &&"
                           + "Time >= NOW();";

                conn = new MySqlConnection(con.ToString());
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        // Checks if a username exists in the database and returns a Boolean to confirm
        public Boolean checkUsernameExists(string usernameIn)
        {
            string username = "";

            con.Open();
            MySqlDataReader reader;
            string query = "SELECT username FROM person WHERE username = '" + usernameIn + "';";

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                username = (reader["username"].ToString());
            }
            con.Close();

            if (username == usernameIn)
                return true;
            else
                return false;
        }

        // Returns the password paired with the email or username that is passed to this method.
        public string recoverPassword(int inputChoice, String input)
        {
            string password = "";
            string query;

            // If a username is given
            if (inputChoice == 1)
                query = "SELECT password FROM person WHERE username = '" + input + "';";
            // if an email or both username and email has been given
            else
                query = "SELECT password FROM person WHERE email = '" + input + "';";

            con.Open();
            MySqlDataReader reader;

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                password = (reader["password"].ToString());
            }
            con.Close();

            return password;
        }

        // Returns the email associated with a given username
        public string getEmail(String username)
        {
            string email = null;
            string query = "SELECT email FROM person WHERE username = '" + username + "';";

            con.Open();
            MySqlDataReader reader;

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                email = (reader["email"].ToString());
            }
            con.Close();

            return email;
        }

        // Gets the person ID of a user based on their unique password
        public int getID(String username)
        {
            int id = -1;
            string query = "SELECT id FROM person WHERE username = '" + username + "';";

            con.Open();
            MySqlDataReader reader;

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                id = int.Parse(reader["id"].ToString());
            }
            con.Close();

            return id;
        }

        // Checks if an email exists in the database
        public int checkEmailExists(String email)
        {
            string query = "SELECT COUNT(*) from person where email = '" + email + "';";
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(con.ToString());
                    MySqlCommand cmd = new MySqlCommand(("SELECT COUNT(*) FROM person WHERE email = '" + email + "';"), conn);
                    cmd.Connection.Open();
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Connection.Close();

                    if (userCount > 0)
                        return 1;
                    else
                        return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        // Returns the index where the specified person opted out of emails.
        public int getOptOutEmail(int id)
        {
            int ret = 0;
            string query = "SELECT opt_out_email FROM person WHERE id ='" + id + "';";

            con.Open();
            MySqlDataReader reader;

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                ret = int.Parse(reader["opt_out_email"].ToString());
            }
            con.Close();

            return ret;
        }


        // Takes an Appointment object and returns the unique id corresponding to that appointment data in the database
        public int getAppointmentID(Appointment appointment)
        {
            int ret = -1;
            string query = "SELECT id FROM appointment WHERE time = '" + appointment.getDate() + "' AND patient_person_id = " + appointment.getPatientID() + ";";

            try
            {
                con.Open();
                MySqlDataReader reader;

                reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    ret = int.Parse(reader["id"].ToString());
                }
                con.Close();

                return ret;
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        // Uses an id to get appointment information from the database, and creates and returns a new Appointment
        // object using that information.
        public Appointment getAppointmentFromID(int appointmentID)
        {
            string time = "";
            int employeeID = -1;
            int patientID = -1;
            int illnessID = -1;
            string query = "SELECT time, doctor_person_id, patient_person_id, illness_id FROM appointment WHERE id = " + appointmentID + ";";

            con.Open();
            MySqlDataReader reader;

            reader = con.ExecuteReader(query);
            while (reader.Read())
            {
                time = DateTime.Parse((reader["time"].ToString())).ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
                employeeID = int.Parse((reader["doctor_person_id"].ToString()));
                patientID = int.Parse((reader["patient_person_id"].ToString()));
                illnessID = int.Parse((reader["illness_id"].ToString()));
            }

            return new Appointment(patientID, employeeID, illnessID, time);
        }
    }
}

