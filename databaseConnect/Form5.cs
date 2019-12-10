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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void studentCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentManagementSystemDataSet.StudentCourse' table. You can move, or remove it, as needed.
            this.studentCourseTableAdapter.Fill(this.departmentManagementSystemDataSet.StudentCourse);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.studentCourseBindingSource.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.studentCourseBindingSource.RemoveCurrent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.studentCourseBindingSource.MovePrevious();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.studentCourseBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you want to exit", "Department Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
            }
        }
    }
}
