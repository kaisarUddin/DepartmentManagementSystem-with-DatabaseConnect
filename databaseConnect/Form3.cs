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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentManagementSystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.departmentManagementSystemDataSet.Department);

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.MovePrevious();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.RemoveCurrent();
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.AddNew();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
