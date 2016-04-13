namespace EmployerApplication
{
    partial class frmHobbies
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
            this.mnuHobby = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSAVE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHobby = new System.Windows.Forms.DataGridView();
            this.HobbyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuHobby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHobby)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuHobby
            // 
            this.mnuHobby.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuHobby.Location = new System.Drawing.Point(0, 0);
            this.mnuHobby.Name = "mnuHobby";
            this.mnuHobby.Size = new System.Drawing.Size(644, 24);
            this.mnuHobby.TabIndex = 0;
            this.mnuHobby.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSAVE,
            this.mnuEXIT});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuSAVE
            // 
            this.mnuSAVE.Name = "mnuSAVE";
            this.mnuSAVE.Size = new System.Drawing.Size(98, 22);
            this.mnuSAVE.Text = "Save";
            this.mnuSAVE.Click += new System.EventHandler(this.mnuSAVE_Click);
            // 
            // mnuEXIT
            // 
            this.mnuEXIT.Name = "mnuEXIT";
            this.mnuEXIT.Size = new System.Drawing.Size(98, 22);
            this.mnuEXIT.Text = "Exit";
            this.mnuEXIT.Click += new System.EventHandler(this.mnuEXIT_Click);
            // 
            // dgvHobby
            // 
            this.dgvHobby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHobby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HobbyType});
            this.dgvHobby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHobby.Location = new System.Drawing.Point(0, 24);
            this.dgvHobby.Name = "dgvHobby";
            this.dgvHobby.Size = new System.Drawing.Size(644, 238);
            this.dgvHobby.TabIndex = 1;
            this.dgvHobby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHobby_CellContentClick);
            // 
            // HobbyType
            // 
            this.HobbyType.DataPropertyName = "Hobbies";
            this.HobbyType.HeaderText = "Hobby Type";
            this.HobbyType.Name = "HobbyType";
            // 
            // frmHobbies
            // 
            this.ClientSize = new System.Drawing.Size(644, 262);
            this.Controls.Add(this.dgvHobby);
            this.Controls.Add(this.mnuHobby);
            this.MainMenuStrip = this.mnuHobby;
            this.Name = "frmHobbies";
            this.Load += new System.EventHandler(this.frmHobbies_Load_1);
            this.mnuHobby.ResumeLayout(false);
            this.mnuHobby.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHobby)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuHobbie;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHobbySave;
        private System.Windows.Forms.ToolStripMenuItem mnuHobbyEXIT;
        private System.Windows.Forms.MenuStrip mnuHobby;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSAVE;
        private System.Windows.Forms.ToolStripMenuItem mnuEXIT;
        private System.Windows.Forms.DataGridView dgvHobby;
        private System.Windows.Forms.DataGridViewTextBoxColumn HobbyType;
    }
}