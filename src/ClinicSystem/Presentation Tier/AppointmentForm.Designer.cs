
namespace Clinic.Presentation_Tier
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.App_Calender = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.checkInStatusList = new System.Windows.Forms.DomainUpDown();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.undoAppointmentButton = new System.Windows.Forms.Button();
            this.redoAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(575, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Add Appointment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddAppointment_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(277, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 55);
            this.label2.TabIndex = 28;
            this.label2.Text = "MERCY CLINIC APPOINTMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select a date below to add the appointments";
            // 
            // App_Calender
            // 
            this.App_Calender.Location = new System.Drawing.Point(79, 144);
            this.App_Calender.Name = "App_Calender";
            this.App_Calender.Size = new System.Drawing.Size(200, 20);
            this.App_Calender.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(925, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Status";
            // 
            // appointmentGrid
            // 
            this.appointmentGrid.AllowUserToAddRows = false;
            this.appointmentGrid.AllowUserToDeleteRows = false;
            this.appointmentGrid.AllowUserToOrderColumns = true;
            this.appointmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGrid.Location = new System.Drawing.Point(12, 263);
            this.appointmentGrid.Name = "appointmentGrid";
            this.appointmentGrid.ReadOnly = true;
            this.appointmentGrid.RowHeadersWidth = 51;
            this.appointmentGrid.Size = new System.Drawing.Size(873, 406);
            this.appointmentGrid.TabIndex = 35;
            this.appointmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(984, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Update Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CheckInStatus_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(984, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "View Appointments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.displayAppointmentsButton);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Symptoms";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(158, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Recieving automated emails";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Toggle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.optInOutEmails_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1177, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 41;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // checkInStatusList
            // 
            this.checkInStatusList.Items.Add("Not Checked In");
            this.checkInStatusList.Items.Add("Checked In");
            this.checkInStatusList.Items.Add("Checked In (Change in symptoms)");
            this.checkInStatusList.Items.Add("Checked In (Late)");
            this.checkInStatusList.Location = new System.Drawing.Point(970, 415);
            this.checkInStatusList.Name = "checkInStatusList";
            this.checkInStatusList.ReadOnly = true;
            this.checkInStatusList.Size = new System.Drawing.Size(204, 20);
            this.checkInStatusList.TabIndex = 43;
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmationLabel.Location = new System.Drawing.Point(368, 199);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(35, 13);
            this.confirmationLabel.TabIndex = 44;
            this.confirmationLabel.Text = "label7";
            this.confirmationLabel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // undoAppointmentButton
            // 
            this.undoAppointmentButton.Location = new System.Drawing.Point(575, 184);
            this.undoAppointmentButton.Name = "undoAppointmentButton";
            this.undoAppointmentButton.Size = new System.Drawing.Size(106, 23);
            this.undoAppointmentButton.TabIndex = 47;
            this.undoAppointmentButton.Text = "Undo Appointment";
            this.undoAppointmentButton.UseVisualStyleBackColor = true;
            this.undoAppointmentButton.Click += new System.EventHandler(this.undoAppointmentButton_Click);
            // 
            // redoAppointmentButton
            // 
            this.redoAppointmentButton.Location = new System.Drawing.Point(575, 216);
            this.redoAppointmentButton.Name = "redoAppointmentButton";
            this.redoAppointmentButton.Size = new System.Drawing.Size(106, 23);
            this.redoAppointmentButton.TabIndex = 48;
            this.redoAppointmentButton.Text = "Redo Appointment";
            this.redoAppointmentButton.UseVisualStyleBackColor = true;
            this.redoAppointmentButton.Click += new System.EventHandler(this.redoAppointmentButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.redoAppointmentButton);
            this.Controls.Add(this.undoAppointmentButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.checkInStatusList);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appointmentGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.App_Calender);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker App_Calender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView appointmentGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DomainUpDown checkInStatusList;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button undoAppointmentButton;
        private System.Windows.Forms.Button redoAppointmentButton;
    }
}