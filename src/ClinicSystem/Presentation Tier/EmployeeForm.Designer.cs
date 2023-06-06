
namespace Clinic.Presentation_Tier
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.Appt_Calender = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchFNameTextBox = new System.Windows.Forms.TextBox();
            this.Search_Label = new System.Windows.Forms.Label();
            this.Search_FName = new System.Windows.Forms.Label();
            this.Search_LName = new System.Windows.Forms.Label();
            this.SearchLNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatientButton = new System.Windows.Forms.Button();
            this.AppointmentView = new System.Windows.Forms.DataGridView();
            this.refreshAppointmentsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.themeButton = new System.Windows.Forms.Button();
            this.undoDeleteButton = new System.Windows.Forms.Button();
            this.redoDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // Appt_Calender
            // 
            this.Appt_Calender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appt_Calender.Location = new System.Drawing.Point(195, 116);
            this.Appt_Calender.Name = "Appt_Calender";
            this.Appt_Calender.TabIndex = 1;
            this.Appt_Calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a date below to view the appointments";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 32F, System.Drawing.FontStyle.Italic);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(369, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "MERCY CLINIC EMPLOYEE";
            // 
            // SearchFNameTextBox
            // 
            this.SearchFNameTextBox.Location = new System.Drawing.Point(597, 137);
            this.SearchFNameTextBox.Name = "SearchFNameTextBox";
            this.SearchFNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchFNameTextBox.TabIndex = 13;
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Label.Location = new System.Drawing.Point(576, 89);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(142, 18);
            this.Search_Label.TabIndex = 14;
            this.Search_Label.Text = "Search for a patient:";
            // 
            // Search_FName
            // 
            this.Search_FName.AutoSize = true;
            this.Search_FName.Location = new System.Drawing.Point(620, 121);
            this.Search_FName.Name = "Search_FName";
            this.Search_FName.Size = new System.Drawing.Size(60, 13);
            this.Search_FName.TabIndex = 15;
            this.Search_FName.Text = "First Name:";
            // 
            // Search_LName
            // 
            this.Search_LName.AutoSize = true;
            this.Search_LName.Location = new System.Drawing.Point(619, 166);
            this.Search_LName.Name = "Search_LName";
            this.Search_LName.Size = new System.Drawing.Size(61, 13);
            this.Search_LName.TabIndex = 16;
            this.Search_LName.Text = "Last Name:";
            // 
            // SearchLNameTextBox
            // 
            this.SearchLNameTextBox.Location = new System.Drawing.Point(597, 182);
            this.SearchLNameTextBox.Name = "SearchLNameTextBox";
            this.SearchLNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchLNameTextBox.TabIndex = 17;
            // 
            // SearchPatientButton
            // 
            this.SearchPatientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPatientButton.Location = new System.Drawing.Point(583, 217);
            this.SearchPatientButton.Name = "SearchPatientButton";
            this.SearchPatientButton.Size = new System.Drawing.Size(127, 21);
            this.SearchPatientButton.TabIndex = 18;
            this.SearchPatientButton.Text = "Search";
            this.SearchPatientButton.UseVisualStyleBackColor = true;
            this.SearchPatientButton.Click += new System.EventHandler(this.patientSearch_Click);
            // 
            // AppointmentView
            // 
            this.AppointmentView.AllowUserToAddRows = false;
            this.AppointmentView.AllowUserToDeleteRows = false;
            this.AppointmentView.AllowUserToOrderColumns = true;
            this.AppointmentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.AppointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentView.Location = new System.Drawing.Point(12, 289);
            this.AppointmentView.Name = "AppointmentView";
            this.AppointmentView.Size = new System.Drawing.Size(891, 380);
            this.AppointmentView.TabIndex = 19;
            // 
            // refreshAppointmentsButton
            // 
            this.refreshAppointmentsButton.Location = new System.Drawing.Point(1025, 373);
            this.refreshAppointmentsButton.Name = "refreshAppointmentsButton";
            this.refreshAppointmentsButton.Size = new System.Drawing.Size(127, 23);
            this.refreshAppointmentsButton.TabIndex = 20;
            this.refreshAppointmentsButton.Text = "Show All Appointments";
            this.refreshAppointmentsButton.UseVisualStyleBackColor = true;
            this.refreshAppointmentsButton.Click += new System.EventHandler(this.refreshAppointmentsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Show All Patients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.displayAllPatientInfo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1025, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete Appointment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteAppointment_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1177, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 23;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // themeButton
            // 
            this.themeButton.Location = new System.Drawing.Point(12, 9);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(87, 38);
            this.themeButton.TabIndex = 24;
            this.themeButton.Text = "Switch to Dark Theme";
            this.themeButton.UseVisualStyleBackColor = true;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // undoDeleteButton
            // 
            this.undoDeleteButton.Location = new System.Drawing.Point(1025, 458);
            this.undoDeleteButton.Name = "undoDeleteButton";
            this.undoDeleteButton.Size = new System.Drawing.Size(127, 23);
            this.undoDeleteButton.TabIndex = 25;
            this.undoDeleteButton.Text = "Undo Delete";
            this.undoDeleteButton.UseVisualStyleBackColor = true;
            this.undoDeleteButton.Click += new System.EventHandler(this.undoDeleteButton_Click);
            // 
            // redoDeleteButton
            // 
            this.redoDeleteButton.Location = new System.Drawing.Point(1025, 503);
            this.redoDeleteButton.Name = "redoDeleteButton";
            this.redoDeleteButton.Size = new System.Drawing.Size(127, 23);
            this.redoDeleteButton.TabIndex = 26;
            this.redoDeleteButton.Text = "Redo Delete";
            this.redoDeleteButton.UseVisualStyleBackColor = true;
            this.redoDeleteButton.Click += new System.EventHandler(this.redoDeleteButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.redoDeleteButton);
            this.Controls.Add(this.undoDeleteButton);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshAppointmentsButton);
            this.Controls.Add(this.AppointmentView);
            this.Controls.Add(this.SearchPatientButton);
            this.Controls.Add(this.SearchLNameTextBox);
            this.Controls.Add(this.Search_LName);
            this.Controls.Add(this.Search_FName);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.SearchFNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Appt_Calender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Data Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.MonthCalendar Appt_Calender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchFNameTextBox;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.Label Search_FName;
        private System.Windows.Forms.Label Search_LName;
        private System.Windows.Forms.TextBox SearchLNameTextBox;
        private System.Windows.Forms.Button SearchPatientButton;
        private System.Windows.Forms.DataGridView AppointmentView;
        private System.Windows.Forms.Button refreshAppointmentsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.Button undoDeleteButton;
        private System.Windows.Forms.Button redoDeleteButton;
    }
}