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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void teachersInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.departmentManagementSystemDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentManagementSystemDataSet.TeachersInfo' table. You can move, or remove it, as needed.
            this.teachersInfoTableAdapter.Fill(this.departmentManagementSystemDataSet.TeachersInfo);

        }

        private void teachersInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.teachersInfoBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersInfoBindingSource.EndEdit();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.teachersInfoBindingSource.RemoveCurrent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.teachersInfoBindingSource.MovePrevious();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.teachersInfoBindingSource.MoveNext();
        }
    }
}
