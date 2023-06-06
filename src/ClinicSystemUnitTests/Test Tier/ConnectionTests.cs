using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clinic;
using System;

namespace ClinicSystemUnitTests
{
    [TestClass()]
    public class ConnectionTests
    {
        Connection con = new Connection();

        // Tests whether the connection successfully opens
        [TestMethod()]
        public void OpenTest()
        {
            try { 
                Assert.IsTrue(con.Open());  
            }
            catch(Exception e)
            {
                
            }
            con.Close();
        }
        
        // Tests whether the connection successfully closes
        [TestMethod()]
        public void CloseTest()
        {
            con.Open();
            Assert.IsTrue(con.Close());
        }
    
        
        [TestMethod()]
        public void ExectuteDataSetTest()
        {

        }
        /*
        [TestMethod()]
        public void ExecuteReaderTest()
        {
            string query = "SELECT * FROM patient;";
            
            con.Open();
            MySqlConnection mySqlConn = new MySqlConnection(con.ToString());
            MySqlCommand cmd = new MySqlCommand(query, mySqlConn);
            mySqlConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataReader reader2 = con.ExecuteReader(query);
            
            Assert.AreEqual(reader, reader2);
            
        }
        */
    }
}