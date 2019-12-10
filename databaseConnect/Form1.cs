using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btndept.Enabled = false;
            btncourse.Enabled = false;
            btnstudent.Enabled = false;
            btnteacher.Enabled = false;
            btnperformance.Enabled = false;
            btnsc.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text=="admin" && txtpassword.Text=="kaisar")
            {
                btndept.Enabled = true;
                btncourse.Enabled = true;
                btnstudent.Enabled = true;
                btnteacher.Enabled = true;
                btnperformance.Enabled = true;
                btnsc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter correct info", "Department Management System");
                txtuser.Focus();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpassword.Clear();
            txtuser.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndept_Click(object sender, EventArgs e)
        {
            Form3 Department = new Form3();
            Department.Show();
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            Form2 Course = new Form2();
            Course.Show();
        }

        private void btnperformance_Click(object sender, EventArgs e)
        {
            Form4 Performance = new Form4();
            Performance.Show();
        }

        private void btnsc_Click(object sender, EventArgs e)
        {
            Form5 StudentCourse = new Form5();
            StudentCourse.Show();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            Form6 Student = new Form6();
            Student.Show();
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            Form7 Teacher = new Form7();
            Teacher.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you want to exit", "Department Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
