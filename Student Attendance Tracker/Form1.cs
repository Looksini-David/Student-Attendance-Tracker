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
            string name = txtStudentName.Text;
            string status = cmbStatus.Text;
            lstAttendance.Items.Add(name + " - " + status);
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;

        }
    }
}
