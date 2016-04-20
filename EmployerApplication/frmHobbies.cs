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
    public partial class frmHobbies : Form
    {
        HobbyList el;
        public frmHobbies()
        {
            InitializeComponent();
        }        

        private void El_Savable(SavableEventArgs e)
        {
            this.mnuHobby.Enabled = e.Savable;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnuSAVE_Click(object sender, EventArgs e)
        {
            if (el.IsSavable() == true)
            {
                el.Save();
                mnuSAVE.Enabled = false;
            }
        }

        private void mnuEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHobbies_Load_1(object sender, EventArgs e)
        {
            dgvHobby.AutoGenerateColumns = false;
            el = new HobbyList();
            el.Savable += El_Savable;
            el = el.GetAll();
            dgvHobby.DataSource = el.List;
        }

        private void dgvHobby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
