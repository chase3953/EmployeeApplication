using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;

namespace EmployerApplication
{
    public partial class Form1 : Form
    {
        EmployeeList el;
        PhoneTypeList phoneTypes;
        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            phoneTypes = new PhoneTypeList();
            phoneTypes = phoneTypes.GetAll();
            dgvEmployeePhones.CellFormatting += DgvEmployeePhones_CellFormatting;
            dgvEmployeePhones.DataError += DgvEmployeePhones_DataError;
            dgvEmployee.AutoGenerateColumns = false;
            el = new EmployeeList();
            dgvEmployeePhones.AutoGenerateColumns = false;
            el.Savable += El_Savable;
            mnuSave.Enabled = false;
            dgvEmployee.RowHeaderMouseDoubleClick += DgvEmployee_RowHeaderMouseDoubleClick;
        }

        private void DgvEmployeePhones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                PopulatePhoneTypes((DataGridViewComboBoxColumn)dgvEmployeePhones.Columns[e.ColumnIndex]);
            }
        }
        private void PopulatePhoneTypes(DataGridViewComboBoxColumn column)
        {
            var c = column;
            {
                if (c.DataSource == null)
                {
                    c.DisplayMember = "Type";
                    c.ValueMember = "Id";
                    c.DataSource = phoneTypes.List;
                }
            }
        }

        private void DgvEmployeePhones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void DgvEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Employee employee = (Employee)dgvEmployee.Rows[e.RowIndex].DataBoundItem;
            dgvEmployeePhones.DataSource = employee.Phones.List;
        }

        private void El_Savable(SavableEventArgs e)
        {
            this.mnuSave.Enabled = e.Savable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            el.Save();        
            mnuSave.Enabled = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            el = el.GetAll();
            dgvEmployee.DataSource = el.List;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
