using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Clinic
{
    /*
     *  This class handles the connecting to and interaction with the MySQL database behind the scenes.
     *  Part of the ease of use comes from having a string that is passed to make the connection with all
     *  the necessary parts. These parts (host, database, userDB, and password will be unique to each individual
     *  based on their MySQL setup.
     */
    public class Connection
    {
        private MySqlConnection conn;
        private static string host = "127.0.0.1"; // The IP of the server. For users running MySQL Workbench in the background, this will be 127.0.0.1 aka localhost.  
        private static string database = "se3330"; // This is the name of the database or "schema" in MySQL Workbench. If the creation script was used it will be set to "se3330"
        private static string userDB = "root"; // The username that the user chooses when setting up their MySQL settings. Is autoed to "root" in the installer but may be different for each user.
        private static string password = "Bluesoccer18!"; // The password of the user account that is determined with setting up their MySQL settings after installing Workbench.
        private static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;

        // Opens the connection to the server using the string provider with user credentials
        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        // Closes the connection to the database
        public bool Close()
        {
            try {
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        // Executes the passed dataset and returns the executed set if successful
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        // Executes the reader and returns it if successful
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return null;
        }

        // Executes the Non-Query with the passed string 
        // Returns the affected value, otherwise -1
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return -1;
        }

        // Returns the string provider to make setup easier for when a different connection type must be declared and used.
        override
        public string ToString()
        {
            return strProvider;
        }
    }
}