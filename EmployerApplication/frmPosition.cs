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
    public partial class frmPosition : Form
    {
        PositionTypeList pt;
        public frmPosition()
        {
            InitializeComponent();
        }

        private void frmPosition_Load_1(object sender, EventArgs e)
        {
            dgvPositionType.AutoGenerateColumns = false;
            pt = new PositionTypeList();
            pt.Savable += Pt_Savable;
            pt = pt.GetAll();
            dgvPositionType.DataSource = pt.List;            
        }

        private void Pt_Savable(SavableEventArgs pt)
        {
            this.mnuPosSave.Enabled = pt.Savable;
        }
       
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pt.Save();
            mnuPosSave.Enabled = false;
        }

        private void mnuPosSave_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
