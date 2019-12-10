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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void performancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.performancesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentManagementSystemDataSet.Performances' table. You can move, or remove it, as needed.
            this.performancesTableAdapter.Fill(this.departmentManagementSystemDataSet.Performances);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.performancesBindingSource.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.performancesBindingSource.RemoveCurrent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.performancesBindingSource.MovePrevious();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.performancesBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.performancesBindingSource.EndEdit();
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
