using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class CreateAccountForm : Form
    {
        DBmanager dbmanager;
        EmailManager emailManager = new EmailManager();
        Login loginForm;
        public CreateAccountForm(Login loginForm, DBmanager dbmanager)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.dbmanager = dbmanager;
        }

        private void showPass1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPass1.Checked ? '\0' : '*';
        }


        private void createAccountButton_Click(object sender, EventArgs e)
        {
            fieldsFilledTimer.Start();

            bool allFilled = true;
            bool passwordsMatch = false;

            if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                passwordsMatch = true;

            if (String.IsNullOrEmpty(firstNameTextBox.Text) || String.IsNullOrEmpty(lastNameTextBox.Text) || String.IsNullOrEmpty(ageTextBox.Text)
                || String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text) || String.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                allFilled = false;
                displayErrorMessage("Not all fields have been filled");
            }

            if (allFilled && passwordsMatch)
            {
                Person person = new Person(firstNameTextBox.Text, lastNameTextBox.Text, Int32.Parse(ageTextBox.Text), (lastNameTextBox.Text + firstNameTextBox.Text).ToLower(),
                                           passwordTextBox.Text, emailTextBox.Text, false);

                dbmanager.AddPerson(person);
                this.Close();
                loginForm.Show();
            }
            else if (allFilled)
                displayErrorMessage("Passwords do not match");
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
        private void displayErrorMessage(string message)
        {
            errorLabel.Text = message;

            var t = new Timer();
            t.Interval = 5000;
            t.Tick += (s, f) =>
            {
                errorLabel.Visible = false;
                t.Stop();
            };
            t.Start();
            errorLabel.Visible = true;
        }

        private void fieldsFilledTimer_Tick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstNameTextBox.Text))
                firstNameTextBox.BackColor = Color.White;
            else
                firstNameTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(lastNameTextBox.Text))
                lastNameTextBox.BackColor = Color.White;
            else
                lastNameTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(ageTextBox.Text))
                ageTextBox.BackColor = Color.White;
            else
                ageTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(emailTextBox.Text))
                emailTextBox.BackColor = Color.White;
            else
                emailTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(passwordTextBox.Text))
                passwordTextBox.BackColor = Color.White;
            else
                passwordTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(confirmPasswordTextBox.Text))
                confirmPasswordTextBox.BackColor = Color.White;
            else
                confirmPasswordTextBox.BackColor = Color.LightCoral;
        }
    }
}
