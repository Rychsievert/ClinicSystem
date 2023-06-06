using Clinic.ui;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            if (!MainContainer.Controls.Contains(ucDepartments.Instance))
            {
                MainContainer.Controls.Add(ucDepartments.Instance);
                ucDepartments.Instance.Dock = DockStyle.Fill;
                ucDepartments.Instance.BringToFront();
            }
            ucDepartments.Instance.BringToFront();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            if (!MainContainer.Controls.Contains(ucAppointments.Instance))
            {
                MainContainer.Controls.Add(ucAppointments.Instance);
                ucAppointments.Instance.Dock = DockStyle.Fill;
                ucAppointments.Instance.BringToFront();
            }
            ucAppointments.Instance.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!MainContainer.Controls.Contains(ucHome.Instance))
            {
                MainContainer.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            ucHome.Instance.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!MainContainer.Controls.Contains(ucHome.Instance))
            {
                MainContainer.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            ucHome.Instance.BringToFront();
        }
    }
}
