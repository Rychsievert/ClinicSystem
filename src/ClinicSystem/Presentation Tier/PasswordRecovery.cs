using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Presentation_Tier
{
    public partial class PasswordRecovery : Form
    {
        private EmailManager emailmngr;
        private DBmanager dbm;
        public PasswordRecovery(EmailManager email, DBmanager dbmanager)
        {
            dbm = dbmanager;
            emailmngr = email;
            InitializeComponent();
        }

        // Calls EmailManager's sendPassword based on the username or email
        //     If neither are there, displays the errorLabel
        private void sendPasswordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text) && String.IsNullOrEmpty(emailTextBox.Text))
                errorLabel.Visible = true;
            else
            {
                if (String.IsNullOrEmpty(emailTextBox.Text))
                    emailmngr.sendPassword(1, usernameTextBox.Text);
                else
                    emailmngr.sendPassword(2, emailTextBox.Text);
                this.Close();
            }
        }

        // Closes out of PasswordRecovery without retrieving the password
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
