namespace Clinic
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.incorrectCredentialsLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.loginTitle = new System.Windows.Forms.Label();
            this.portalTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ageCounter = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.createPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createConfirmPasswordlabel = new System.Windows.Forms.Label();
            this.missingInformationLabel = new System.Windows.Forms.Label();
            this.createShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.fieldsFilledTimer = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.recoverPasswordButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(171, 242);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(171, 308);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.Brown;
            this.createAccountLabel.Location = new System.Drawing.Point(713, 150);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(349, 19);
            this.createAccountLabel.TabIndex = 2;
            this.createAccountLabel.Text = "Don\'t have an account with us yet?";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Location = new System.Drawing.Point(174, 261);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(191, 20);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(174, 327);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(191, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(215, 367);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountButton.Location = new System.Drawing.Point(837, 498);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(108, 23);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(391, 329);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordCheckBox.TabIndex = 7;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // incorrectCredentialsLabel
            // 
            this.incorrectCredentialsLabel.AutoSize = true;
            this.incorrectCredentialsLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectCredentialsLabel.Location = new System.Drawing.Point(183, 410);
            this.incorrectCredentialsLabel.Name = "incorrectCredentialsLabel";
            this.incorrectCredentialsLabel.Size = new System.Drawing.Size(170, 13);
            this.incorrectCredentialsLabel.TabIndex = 8;
            this.incorrectCredentialsLabel.Text = "Username or Password is incorrect";
            this.incorrectCredentialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectCredentialsLabel.Visible = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Clinic.Properties.Resources.Mercy_Clinic_Logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(101, 81);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 9;
            this.logoPictureBox.TabStop = false;
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(119, 21);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(82, 27);
            this.loginTitle.TabIndex = 10;
            this.loginTitle.Text = "Login";
            // 
            // portalTitle
            // 
            this.portalTitle.AutoSize = true;
            this.portalTitle.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portalTitle.ForeColor = System.Drawing.Color.Brown;
            this.portalTitle.Location = new System.Drawing.Point(151, 48);
            this.portalTitle.Name = "portalTitle";
            this.portalTitle.Size = new System.Drawing.Size(96, 27);
            this.portalTitle.TabIndex = 11;
            this.portalTitle.Text = "Portal";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(170, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Already a member or an employee?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Please note that the username and password fields are case sensitive.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(798, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(798, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Full Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(801, 216);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.Location = new System.Drawing.Point(801, 255);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(798, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(798, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(798, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Age";
            // 
            // ageCounter
            // 
            this.ageCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageCounter.Location = new System.Drawing.Point(837, 308);
            this.ageCounter.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageCounter.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageCounter.Name = "ageCounter";
            this.ageCounter.ReadOnly = true;
            this.ageCounter.Size = new System.Drawing.Size(39, 20);
            this.ageCounter.TabIndex = 22;
            this.ageCounter.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(798, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Location = new System.Drawing.Point(801, 359);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(191, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // createPasswordTextBox
            // 
            this.createPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createPasswordTextBox.Location = new System.Drawing.Point(801, 407);
            this.createPasswordTextBox.Name = "createPasswordTextBox";
            this.createPasswordTextBox.PasswordChar = '*';
            this.createPasswordTextBox.Size = new System.Drawing.Size(191, 20);
            this.createPasswordTextBox.TabIndex = 25;
            // 
            // createConfirmPasswordTextBox
            // 
            this.createConfirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createConfirmPasswordTextBox.Location = new System.Drawing.Point(801, 460);
            this.createConfirmPasswordTextBox.Name = "createConfirmPasswordTextBox";
            this.createConfirmPasswordTextBox.PasswordChar = '*';
            this.createConfirmPasswordTextBox.Size = new System.Drawing.Size(191, 20);
            this.createConfirmPasswordTextBox.TabIndex = 27;
            // 
            // createConfirmPasswordlabel
            // 
            this.createConfirmPasswordlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createConfirmPasswordlabel.AutoSize = true;
            this.createConfirmPasswordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createConfirmPasswordlabel.Location = new System.Drawing.Point(798, 441);
            this.createConfirmPasswordlabel.Name = "createConfirmPasswordlabel";
            this.createConfirmPasswordlabel.Size = new System.Drawing.Size(116, 16);
            this.createConfirmPasswordlabel.TabIndex = 26;
            this.createConfirmPasswordlabel.Text = "Confirm Password";
            // 
            // missingInformationLabel
            // 
            this.missingInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingInformationLabel.ForeColor = System.Drawing.Color.Red;
            this.missingInformationLabel.Location = new System.Drawing.Point(773, 533);
            this.missingInformationLabel.Name = "missingInformationLabel";
            this.missingInformationLabel.Size = new System.Drawing.Size(245, 20);
            this.missingInformationLabel.TabIndex = 28;
            this.missingInformationLabel.Text = "label10";
            this.missingInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.missingInformationLabel.Visible = false;
            // 
            // createShowPasswordCheckBox
            // 
            this.createShowPasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createShowPasswordCheckBox.AutoSize = true;
            this.createShowPasswordCheckBox.Location = new System.Drawing.Point(1022, 409);
            this.createShowPasswordCheckBox.Name = "createShowPasswordCheckBox";
            this.createShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.createShowPasswordCheckBox.TabIndex = 29;
            this.createShowPasswordCheckBox.Text = "Show Password";
            this.createShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.createShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.createShowPasswordCheckBox_CheckedChanged);
            // 
            // fieldsFilledTimer
            // 
            this.fieldsFilledTimer.Tick += new System.EventHandler(this.fieldsFilledTimer_Tick);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(170, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Forgot Your Password?";
            // 
            // recoverPasswordButton
            // 
            this.recoverPasswordButton.Location = new System.Drawing.Point(211, 508);
            this.recoverPasswordButton.Name = "recoverPasswordButton";
            this.recoverPasswordButton.Size = new System.Drawing.Size(113, 23);
            this.recoverPasswordButton.TabIndex = 31;
            this.recoverPasswordButton.Text = "Recover Password";
            this.toolTip1.SetToolTip(this.recoverPasswordButton, "You will have to provide your eaccount\'s username or email");
            this.recoverPasswordButton.UseVisualStyleBackColor = true;
            this.recoverPasswordButton.Click += new System.EventHandler(this.recoverPasswordButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.recoverPasswordButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.createShowPasswordCheckBox);
            this.Controls.Add(this.missingInformationLabel);
            this.Controls.Add(this.createConfirmPasswordTextBox);
            this.Controls.Add(this.createConfirmPasswordlabel);
            this.Controls.Add(this.createPasswordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ageCounter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.portalTitle);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.incorrectCredentialsLabel);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.passwordLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label incorrectCredentialsLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label portalTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ageCounter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox createPasswordTextBox;
        private System.Windows.Forms.TextBox createConfirmPasswordTextBox;
        private System.Windows.Forms.Label createConfirmPasswordlabel;
        private System.Windows.Forms.Label missingInformationLabel;
        private System.Windows.Forms.CheckBox createShowPasswordCheckBox;
        private System.Windows.Forms.Timer fieldsFilledTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button recoverPasswordButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}