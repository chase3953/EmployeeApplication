namespace EmployerApplication
{
    partial class frmPosition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPosSave = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPositionType = new System.Windows.Forms.DataGridView();
            this.PositionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMinimumPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaximimPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuPosSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionType)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPosSave
            // 
            this.mnuPosSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuPosSave.Location = new System.Drawing.Point(0, 0);
            this.mnuPosSave.Name = "mnuPosSave";
            this.mnuPosSave.Size = new System.Drawing.Size(1045, 24);
            this.mnuPosSave.TabIndex = 0;
            this.mnuPosSave.Text = "menuStrip2";
            this.mnuPosSave.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuPosSave_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem3.Text = "Save";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // dgvPositionType
            // 
            this.dgvPositionType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositionType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionType,
            this.ColMinimumPay,
            this.ColMaximimPay});
            this.dgvPositionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPositionType.Location = new System.Drawing.Point(0, 24);
            this.dgvPositionType.Name = "dgvPositionType";
            this.dgvPositionType.Size = new System.Drawing.Size(1045, 238);
            this.dgvPositionType.TabIndex = 1;
            // 
            // PositionType
            // 
            this.PositionType.DataPropertyName = "Position";
            this.PositionType.HeaderText = "Position Type";
            this.PositionType.Name = "PositionType";
            // 
            // ColMinimumPay
            // 
            this.ColMinimumPay.DataPropertyName = "MinimumPay";
            this.ColMinimumPay.HeaderText = "Minimum Pay";
            this.ColMinimumPay.Name = "ColMinimumPay";
            // 
            // ColMaximimPay
            // 
            this.ColMaximimPay.DataPropertyName = "MaximumPay";
            this.ColMaximimPay.HeaderText = "Maximum Pay";
            this.ColMaximimPay.Name = "ColMaximimPay";
            // 
            // frmPosition
            // 
            this.ClientSize = new System.Drawing.Size(1045, 262);
            this.Controls.Add(this.dgvPositionType);
            this.Controls.Add(this.mnuPosSave);
            this.MainMenuStrip = this.mnuPosSave;
            this.Name = "frmPosition";
            this.Load += new System.EventHandler(this.frmPosition_Load_1);
            this.mnuPosSave.ResumeLayout(false);
            this.mnuPosSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip mnuSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.MenuStrip mnuPosSave;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridView dgvPositionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMinimumPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaximimPay;
    }
}