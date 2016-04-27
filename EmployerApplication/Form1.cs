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
        EmailTypeList emailTypes;
        Employee employee;



        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            phoneTypes = new PhoneTypeList();
            phoneTypes = phoneTypes.GetAll();
            emailTypes = new EmailTypeList();
            emailTypes = emailTypes.GetAll();
            HobbyList hobbyList;
            hobbyList = new HobbyList();
            hobbyList.GetAll();
            LoadHobbies(hobbyList);

            dgvEmployeePhones.CellFormatting += DgvEmployeePhones_CellFormatting;
            dgvEmployeeEmail.CellFormatting += DgvEmployeeEmail_CellFormatting;
            dgvEmployeePhones.DataError += DgvEmployeePhones_DataError;
            dgvEmployeeEmail.DataError += DgvEmployeeEmail_DataError;
            dgvEmployee.AutoGenerateColumns = false;
            el = new EmployeeList();
            dgvEmployeePhones.AutoGenerateColumns = false;
            dgvEmployeeEmail.AutoGenerateColumns = false;
            el.Savable += El_Savable;
            mnuSave.Enabled = false;
            dgvEmployee.RowHeaderMouseDoubleClick += DgvEmployee_RowHeaderMouseDoubleClick;
        }

        private void LoadHobbies(HobbyList Hobbies)
        {
            foreach (Hobby hobby in Hobbies.List)
            {
                CheckBox cb = new CheckBox();
                cb.CheckStateChanged += Cb_CheckStateChanged;
                cb.Text = hobby.HobbyName;
                cb.Tag = hobby.Id;
                cb.AutoSize = true;
                this.flpHobby.Controls.Add(cb);
            }
        }

        private void UnSubscribeStateChanged()
        {
            foreach (CheckBox cb in flpHobby.Controls)
            {
                cb.CheckedChanged -= Cb_CheckStateChanged;
            }
        }

        private void SubscribeStateChanged()
        {
            foreach (CheckBox cb in flpHobby.Controls)
            {
                cb.CheckedChanged += Cb_CheckStateChanged;
            }
        }

        private void Cb_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                EmployeeHobby eh = new EmployeeHobby();
                eh.EmployeeID = employee.Id;
                eh.HobbyID = (Guid)cb.Tag;
                employee.HobbyName.List.Add(eh);
                employee.Save();
            }
            else
            {
                foreach (EmployeeHobby eh in employee.HobbyName.List)
                {
                    if (eh.HobbyID == (Guid)cb.Tag)
                    {
                        eh.Deleted = true;
                        employee.Save();
                        break;
                    }
                }
            }
        }

        private void DgvEmployeeEmail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void DgvEmployeeEmail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                PopulateEmailTypes((DataGridViewComboBoxColumn)dgvEmployeeEmail.Columns[e.ColumnIndex]);
            }
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
        private void PopulateEmailTypes(DataGridViewComboBoxColumn column)
        {
            var c = column;
            {
                if (c.DataSource == null)
                {
                    c.DisplayMember = "Type";
                    c.ValueMember = "Id";
                    c.DataSource = emailTypes.List;
                }
            }
        }

        private void DgvEmployeePhones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void DgvEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employee = (Employee)dgvEmployee.Rows[e.RowIndex].DataBoundItem;
            dgvEmployeePhones.DataSource = employee.Phones.List;
            dgvEmployeeEmail.DataSource = employee.Emails.List;
            UnSubscribeStateChanged();
            SetEmployeeHobbies();
            SubscribeStateChanged();
        }

        private void SetEmployeeHobbies()
        {
            for (int j = 0; j < employee.HobbyName.List.Count-1; j++)
            {
                for (int i = 0; i < flpHobby.Controls.Count-1; i++)
                {
                    if ((Guid)flpHobby.Controls[i].Tag == employee.HobbyName.List[j].HobbyID)
                    {
                        ((CheckBox)flpHobby.Controls[i]).Checked = true;
                    }
                }
            } 
        }

        private void El_Savable(SavableEventArgs e)
        {
            this.mnuSave.Enabled = e.Savable;
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

        private void gbHobby_Enter(object sender, EventArgs e)
        {

        }
    }
}
