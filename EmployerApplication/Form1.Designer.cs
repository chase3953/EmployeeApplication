namespace EmployerApplication
{
    partial class Form1
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
            this.mnuEmployeeName = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSEARCH = new System.Windows.Forms.TabPage();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmployeePhone = new System.Windows.Forms.TabPage();
            this.dgvEmployeePhones = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabEmployeeEmail = new System.Windows.Forms.TabPage();
            this.dgvEmployeeEmail = new System.Windows.Forms.DataGridView();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabHobby = new System.Windows.Forms.TabPage();
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.mnuEmployeeName.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSEARCH.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabEmployeePhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePhones)).BeginInit();
            this.tabEmployeeEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeEmail)).BeginInit();
            this.tabHobby.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuEmployeeName
            // 
            this.mnuEmployeeName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuEmployeeName.Location = new System.Drawing.Point(0, 0);
            this.mnuEmployeeName.Name = "mnuEmployeeName";
            this.mnuEmployeeName.Size = new System.Drawing.Size(808, 24);
            this.mnuEmployeeName.TabIndex = 1;
            this.mnuEmployeeName.Text = "menuStrip1";
            this.mnuEmployeeName.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuEmployeeName_ItemClicked);
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
            this.mnuSave.Size = new System.Drawing.Size(98, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(98, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSEARCH);
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabEmployeePhone);
            this.tabControl1.Controls.Add(this.tabEmployeeEmail);
            this.tabControl1.Controls.Add(this.tabHobby);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 363);
            this.tabControl1.TabIndex = 2;
            // 
            // tabSEARCH
            // 
            this.tabSEARCH.Controls.Add(this.btnSEARCH);
            this.tabSEARCH.Location = new System.Drawing.Point(4, 22);
            this.tabSEARCH.Name = "tabSEARCH";
            this.tabSEARCH.Padding = new System.Windows.Forms.Padding(3);
            this.tabSEARCH.Size = new System.Drawing.Size(800, 337);
            this.tabSEARCH.TabIndex = 0;
            this.tabSEARCH.Text = "Search";
            this.tabSEARCH.UseVisualStyleBackColor = true;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Location = new System.Drawing.Point(8, 6);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(75, 23);
            this.btnSEARCH.TabIndex = 2;
            this.btnSEARCH.Text = "Search";
            this.btnSEARCH.UseVisualStyleBackColor = true;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.dgvEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(800, 337);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.ColLastName});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(794, 331);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "Firstname";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            // 
            // ColLastName
            // 
            this.ColLastName.DataPropertyName = "Lastname";
            this.ColLastName.HeaderText = "Last Name";
            this.ColLastName.Name = "ColLastName";
            // 
            // tabEmployeePhone
            // 
            this.tabEmployeePhone.Controls.Add(this.dgvEmployeePhones);
            this.tabEmployeePhone.Location = new System.Drawing.Point(4, 22);
            this.tabEmployeePhone.Name = "tabEmployeePhone";
            this.tabEmployeePhone.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeePhone.Size = new System.Drawing.Size(800, 337);
            this.tabEmployeePhone.TabIndex = 2;
            this.tabEmployeePhone.Text = "Employee Phones";
            this.tabEmployeePhone.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeePhones
            // 
            this.dgvEmployeePhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNumber,
            this.PhoneType});
            this.dgvEmployeePhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeePhones.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployeePhones.Name = "dgvEmployeePhones";
            this.dgvEmployeePhones.Size = new System.Drawing.Size(794, 331);
            this.dgvEmployeePhones.TabIndex = 0;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "Phone";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // PhoneType
            // 
            this.PhoneType.DataPropertyName = "PhoneTypeId";
            this.PhoneType.HeaderText = "Type of Phone";
            this.PhoneType.Name = "PhoneType";
            // 
            // tabEmployeeEmail
            // 
            this.tabEmployeeEmail.Controls.Add(this.dgvEmployeeEmail);
            this.tabEmployeeEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmployeeEmail.Name = "tabEmployeeEmail";
            this.tabEmployeeEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeEmail.Size = new System.Drawing.Size(800, 337);
            this.tabEmployeeEmail.TabIndex = 3;
            this.tabEmployeeEmail.Text = "Employee Email";
            this.tabEmployeeEmail.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeeEmail
            // 
            this.dgvEmployeeEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeEmail,
            this.EmailType});
            this.dgvEmployeeEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeEmail.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployeeEmail.Name = "dgvEmployeeEmail";
            this.dgvEmployeeEmail.Size = new System.Drawing.Size(794, 331);
            this.dgvEmployeeEmail.TabIndex = 0;
            this.dgvEmployeeEmail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.DataPropertyName = "Email";
            this.EmployeeEmail.HeaderText = "Email";
            this.EmployeeEmail.Name = "EmployeeEmail";
            // 
            // EmailType
            // 
            this.EmailType.DataPropertyName = "EmailTypeID";
            this.EmailType.HeaderText = "Email Type";
            this.EmailType.Name = "EmailType";
            this.EmailType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabHobby
            // 
            this.tabHobby.Controls.Add(this.gbHobby);
            this.tabHobby.Location = new System.Drawing.Point(4, 22);
            this.tabHobby.Name = "tabHobby";
            this.tabHobby.Padding = new System.Windows.Forms.Padding(3);
            this.tabHobby.Size = new System.Drawing.Size(800, 337);
            this.tabHobby.TabIndex = 4;
            this.tabHobby.Text = "Employee Hobbies";
            this.tabHobby.UseVisualStyleBackColor = true;
            // 
            // gbHobby
            // 
            this.gbHobby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHobby.Location = new System.Drawing.Point(3, 3);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(794, 331);
            this.gbHobby.TabIndex = 0;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "Hobbies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 387);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnuEmployeeName);
            this.MainMenuStrip = this.mnuEmployeeName;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuEmployeeName.ResumeLayout(false);
            this.mnuEmployeeName.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSEARCH.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabEmployeePhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePhones)).EndInit();
            this.tabEmployeeEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeEmail)).EndInit();
            this.tabHobby.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuEmployeeName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSEARCH;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.TabPage tabEmployeePhone;
        private System.Windows.Forms.DataGridView dgvEmployeePhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhoneType;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.TabPage tabEmployeeEmail;
        private System.Windows.Forms.DataGridView dgvEmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmailType;
        private System.Windows.Forms.TabPage tabHobby;
        private System.Windows.Forms.GroupBox gbHobby;
    }
}

