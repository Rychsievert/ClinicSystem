namespace Clinic.Presentation_Tier
{
    partial class PasswordRecovery
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.sendPasswordButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(69, 28);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(185, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(69, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(185, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Brown;
            this.usernameLabel.Location = new System.Drawing.Point(78, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(176, 16);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Please enter username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Brown;
            this.emailLabel.Location = new System.Drawing.Point(123, 73);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 16);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "or email";
            // 
            // sendPasswordButton
            // 
            this.sendPasswordButton.Location = new System.Drawing.Point(57, 131);
            this.sendPasswordButton.Name = "sendPasswordButton";
            this.sendPasswordButton.Size = new System.Drawing.Size(126, 23);
            this.sendPasswordButton.TabIndex = 4;
            this.sendPasswordButton.Text = "Send me my password";
            this.toolTip.SetToolTip(this.sendPasswordButton, "An email containing your password will be sent to your address");
            this.sendPasswordButton.UseVisualStyleBackColor = true;
            this.sendPasswordButton.Click += new System.EventHandler(this.sendPasswordButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(91, 179);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(140, 13);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Please fill in one of the fields";
            this.errorLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(189, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.sendPasswordButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // The text box the user enters their username into to retrieve their password
        private System.Windows.Forms.TextBox usernameTextBox;

        // The text box the user enters their email into to retrieve their password
        private System.Windows.Forms.TextBox emailTextBox;

        // The label above usernameTextBox
        private System.Windows.Forms.Label usernameLabel;

        // The label above emailTextBox
        private System.Windows.Forms.Label emailLabel;

        // The button that sends the password via email
        private System.Windows.Forms.Button sendPasswordButton;

        // The label that relays error messages to the user
        private System.Windows.Forms.Label errorLabel;

        // Creates a ToolTip used by the buttons
        private System.Windows.Forms.ToolTip toolTip;

        // Returns to the login form without retrieving the password
        private System.Windows.Forms.Button cancelButton;
    }
}