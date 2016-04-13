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
    public partial class frmDepartment : Form
    {
        DepartmentList dl;
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void mnusFILE_Click(object sender, EventArgs e)
        {

        }

        private void mnusSAVE_Click(object sender, EventArgs e)
        {
            if (dl.IsSavable() == true)
            {
                dl.Save();
                mnusSAVE.Enabled = false;
            }
        }

        private void mnusEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            dgvDepartment.AutoGenerateColumns = false;
            dl = new DepartmentList();
            dl.Savable += Dl_Savable;
            dl = dl.GetAll();
            dgvDepartment.DataSource = dl.List;
        }

        private void Dl_Savable(SavableEventArgs e)
        {
            this.mnuDepartment.Enabled = e.Savable;
        }
    }
}
