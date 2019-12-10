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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentManagementSystemDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.departmentManagementSystemDataSet.Courses);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.MovePrevious();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.RemoveCurrent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.AddNew();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
