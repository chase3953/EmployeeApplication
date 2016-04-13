namespace EmployerApplication
{
    partial class frmPhoneType
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
            this.dgvPhoneType = new System.Windows.Forms.DataGridView();
            this.mnuPhoneType = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneType)).BeginInit();
            this.mnuPhoneType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhoneType
            // 
            this.dgvPhoneType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvPhoneType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhoneType.Location = new System.Drawing.Point(0, 24);
            this.dgvPhoneType.Name = "dgvPhoneType";
            this.dgvPhoneType.Size = new System.Drawing.Size(726, 238);
            this.dgvPhoneType.TabIndex = 1;
            this.dgvPhoneType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhoneType_CellContentClick);
            // 
            // mnuPhoneType
            // 
            this.mnuPhoneType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuPhoneType.Location = new System.Drawing.Point(0, 0);
            this.mnuPhoneType.Name = "mnuPhoneType";
            this.mnuPhoneType.Size = new System.Drawing.Size(726, 24);
            this.mnuPhoneType.TabIndex = 2;
            this.mnuPhoneType.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "PhoneType";
            this.Column1.Name = "Column1";
            // 
            // frmPhoneType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(726, 262);
            this.Controls.Add(this.dgvPhoneType);
            this.Controls.Add(this.mnuPhoneType);
            this.Name = "frmPhoneType";
            this.Text = "frmPhoneType";
            this.Load += new System.EventHandler(this.frmPhoneType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneType)).EndInit();
            this.mnuPhoneType.ResumeLayout(false);
            this.mnuPhoneType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhoneType;
        private System.Windows.Forms.MenuStrip mnuPhoneType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}