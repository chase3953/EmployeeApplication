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
    public partial class frmPhoneType : Form
    {
        PhoneTypeList pt;
        public frmPhoneType()
        {
            InitializeComponent();
        }

        private void dgvPhoneType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPhoneType_Load(object sender, EventArgs e)
        {
            dgvPhoneType.AutoGenerateColumns = false;
            pt = new PhoneTypeList();
            pt.Savable += Pt_Savable;
            pt = pt.GetAll();
            dgvPhoneType.DataSource = pt.List;
            mnuSave.Enabled = false;
        }

        private void Pt_Savable(SavableEventArgs pt)
        {
            this.mnuSave.Enabled = pt.Savable;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            pt.Save();
            mnuSave.Enabled = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
