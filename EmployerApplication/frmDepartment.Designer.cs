namespace EmployerApplication
{
    partial class frmDepartment
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
            this.mnuDepartment = new System.Windows.Forms.MenuStrip();
            this.mnusFILE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusSAVE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuDepartment
            // 
            this.mnuDepartment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnusFILE});
            this.mnuDepartment.Location = new System.Drawing.Point(0, 0);
            this.mnuDepartment.Name = "mnuDepartment";
            this.mnuDepartment.Size = new System.Drawing.Size(482, 24);
            this.mnuDepartment.TabIndex = 0;
            this.mnuDepartment.Text = "menuStrip1";
            // 
            // mnusFILE
            // 
            this.mnusFILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnusSAVE,
            this.mnusEXIT});
            this.mnusFILE.Name = "mnusFILE";
            this.mnusFILE.Size = new System.Drawing.Size(37, 20);
            this.mnusFILE.Text = "File";
            this.mnusFILE.Click += new System.EventHandler(this.mnusFILE_Click);
            // 
            // mnusSAVE
            // 
            this.mnusSAVE.Name = "mnusSAVE";
            this.mnusSAVE.Size = new System.Drawing.Size(152, 22);
            this.mnusSAVE.Text = "Save";
            this.mnusSAVE.Click += new System.EventHandler(this.mnusSAVE_Click);
            // 
            // mnusEXIT
            // 
            this.mnusEXIT.Name = "mnusEXIT";
            this.mnusEXIT.Size = new System.Drawing.Size(152, 22);
            this.mnusEXIT.Text = "Exit";
            this.mnusEXIT.Click += new System.EventHandler(this.mnusEXIT_Click);
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department,
            this.Abbreviation});
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(0, 24);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(482, 238);
            this.dgvDepartment.TabIndex = 1;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Name";
            this.Department.HeaderText = "Department Name";
            this.Department.Name = "Department";
            // 
            // Abbreviation
            // 
            this.Abbreviation.DataPropertyName = "Abbreviation";
            this.Abbreviation.HeaderText = "Department Abbreviation";
            this.Abbreviation.Name = "Abbreviation";
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 262);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.mnuDepartment);
            this.MainMenuStrip = this.mnuDepartment;
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.mnuDepartment.ResumeLayout(false);
            this.mnuDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDepartment;
        private System.Windows.Forms.ToolStripMenuItem mnusFILE;
        private System.Windows.Forms.ToolStripMenuItem mnusSAVE;
        private System.Windows.Forms.ToolStripMenuItem mnusEXIT;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abbreviation;
    }
}