using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text.Trim();
            string status = cmbStatus.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Student name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Student name must only contain letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please select an attendance status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstAttendance.Items.Add($"{name} - {status}");
            lstAttendance.Items.Add($"{name} - {status}");
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstAttendance.SelectedIndex != -1)
            {
                lstAttendance.Items.RemoveAt(lstAttendance.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
}
