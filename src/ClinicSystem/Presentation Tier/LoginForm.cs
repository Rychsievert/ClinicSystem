using Clinic.Presentation_Tier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Login : Form
    {
        private Connection con = new Connection();
        private DBmanager dbmanager = new DBmanager();
        private ClinicSystem clinicSystem = ClinicSystem.getInstance();
        private EmailManager emailmngr = new EmailManager();
        public Login()
        {
            InitializeComponent();
        }

        // Displays or hides the characters in the login password textbox.
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        // When a user clicks login, this is the logic that is executed.
        private void loginButton_Click(object sender, EventArgs e)
        {
            // If both a username and password have been supplied
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                // determine if the credentials belong to a patient or employee account
                int access = dbmanager.LoginUser(usernameTextBox.Text, passwordTextBox.Text);

                // user is a patient
                if (access == 0)
                {
                    clinicSystem.SetPatient(usernameTextBox.Text, dbmanager.getID(usernameTextBox.Text));
                    AppointmentForm aptForm = new AppointmentForm(this, dbmanager, usernameTextBox.Text);
                    this.Hide();
                    aptForm.Show();
                }
                //user is an employee
                else if (access == 1)
                {
                    clinicSystem.SetEmployee(usernameTextBox.Text, dbmanager.getID(usernameTextBox.Text));
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    EmployeeForm empForm = new EmployeeForm(this, dbmanager);
                    this.Hide();
                    empForm.Show();
                }
                // The username and password combination was not found in the database
                else
                    displayErrorMessage(incorrectCredentialsLabel, "Incorrect username or password"); // Show the incorrect username or password message for 5 seconds
            }
            // The username or password field (or both) was left blank
            else
                displayErrorMessage(incorrectCredentialsLabel, "Username or Password cannot be blank"); // Show the blank username or password message for 5 seconds
        }

        // When a user clicks the "Create Account" button this logic executes.
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            bool allFilled = true;
            bool passwordsMatch = false;
            int emailCheck = dbmanager.checkEmailExists(emailTextBox.Text); //Check if the email exists in the database. 

            if (emailCheck == -1)
                displayErrorMessage(missingInformationLabel, "Connection Error");
            else
            {
                // Check if the supplied password and password confirmation match eachother
                if (createPasswordTextBox.Text == createConfirmPasswordTextBox.Text)
                    passwordsMatch = true;

                // If not all required fields were supplied values, show an error
                if (String.IsNullOrEmpty(firstNameTextBox.Text) || String.IsNullOrEmpty(lastNameTextBox.Text) || String.IsNullOrEmpty(emailTextBox.Text)
                    || String.IsNullOrEmpty(createPasswordTextBox.Text) || String.IsNullOrEmpty(createConfirmPasswordTextBox.Text))
                {
                    fieldsFilledTimer.Start();
                    allFilled = false;
                    displayErrorMessage(missingInformationLabel, "Not all fields have been filled");
                }
                // If the email already belongs to an existing account, show an error
                else if (emailCheck == 1)
                    displayErrorMessage(missingInformationLabel, "An account with that email already exists");

                // if all required fields were filled and the passwords match
                else if (allFilled && passwordsMatch)
                {
                    int userNumber = 0;
                    string usernameOriginal = (lastNameTextBox.Text + firstNameTextBox.Text).ToLower();
                    string username = usernameOriginal;

                    // Usernames are based off name, buit must be unique. Add a number to the end of the name supplied username.
                    // If cherryryan1 exists, the next Ryan Cherry's usernmame will be cherryryan2
                    while (userNumber != -1)
                    {
                        if (dbmanager.checkUsernameExists(username))
                        {
                            userNumber++;
                            username = usernameOriginal + userNumber;
                        }
                        else
                            userNumber = -1;
                    }

                    // do this first to check if the email is in a proper form
                    int properEmail = emailmngr.sendMail(emailTextBox.Text, "Thank you for creating account with Mercy Clinic", ("Thank you for creating an account with the Mercy Clinic system."
                        + " Your generated username is: " + username + "."));
                    if (properEmail == -1)
                        displayErrorMessage(missingInformationLabel, "Email is not of proper form");
                    //finally, if everything checks out, create a person object with supplied info and add it to the database
                    else
                    {
                        Person newPerson = new Person(firstNameTextBox.Text, lastNameTextBox.Text, (int)ageCounter.Value, username,
                                                   createPasswordTextBox.Text, emailTextBox.Text, false);
                        dbmanager.AddPerson(newPerson);

                        //reset all the text fields for inputting information
                        firstNameTextBox.Clear();
                        lastNameTextBox.Clear();
                        emailTextBox.Clear();
                        createPasswordTextBox.Clear();
                        createConfirmPasswordTextBox.Clear();
                        ageCounter.Value = 18;

                        fieldsFilledTimer.Stop();
                    }
                }
                // If the password fields do not match display an error
                else if (allFilled)
                    displayErrorMessage(missingInformationLabel, "Passwords do not match");
            }
        }

        // Displays a specified message for 5 seconds in a red label
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

        // displays 
        private void createShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            createPasswordTextBox.PasswordChar = createShowPasswordCheckBox.Checked ? '\0' : '*';
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

            if (!String.IsNullOrEmpty(emailTextBox.Text))
                emailTextBox.BackColor = Color.White;
            else
                emailTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(createPasswordTextBox.Text))
                createPasswordTextBox.BackColor = Color.White;
            else
                createPasswordTextBox.BackColor = Color.LightCoral;

            if (!String.IsNullOrEmpty(createConfirmPasswordTextBox.Text))
                createConfirmPasswordTextBox.BackColor = Color.White;
            else
                createConfirmPasswordTextBox.BackColor = Color.LightCoral;
        }

        private void recoverPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery(emailmngr, dbmanager);
            passwordRecovery.Show();
        }
    }
}
