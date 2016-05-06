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
            this.tabSubordinate = new System.Windows.Forms.TabPage();
            this.dgvSubordinate = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabHobby = new System.Windows.Forms.TabPage();
            this.flpHobby = new System.Windows.Forms.FlowLayoutPanel();
            this.tabEmployeeEmail = new System.Windows.Forms.TabPage();
            this.dgvEmployeeEmail = new System.Windows.Forms.DataGridView();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabEmployeePhone = new System.Windows.Forms.TabPage();
            this.dgvEmployeePhones = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabSEARCH = new System.Windows.Forms.TabPage();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabFamily = new System.Windows.Forms.TabPage();
            this.dgvFamily = new System.Windows.Forms.DataGridView();
            this.clmFamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuEmployeeName.SuspendLayout();
            this.tabSubordinate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinate)).BeginInit();
            this.tabHobby.SuspendLayout();
            this.tabEmployeeEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeEmail)).BeginInit();
            this.tabEmployeePhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePhones)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabSEARCH.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.tabFamily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).BeginInit();
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
            // tabSubordinate
            // 
            this.tabSubordinate.Controls.Add(this.dgvSubordinate);
            this.tabSubordinate.Location = new System.Drawing.Point(4, 22);
            this.tabSubordinate.Name = "tabSubordinate";
            this.tabSubordinate.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubordinate.Size = new System.Drawing.Size(800, 337);
            this.tabSubordinate.TabIndex = 5;
            this.tabSubordinate.Text = "Subordinates";
            this.tabSubordinate.UseVisualStyleBackColor = true;
            // 
            // dgvSubordinate
            // 
            this.dgvSubordinate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubordinate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName});
            this.dgvSubordinate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubordinate.Location = new System.Drawing.Point(3, 3);
            this.dgvSubordinate.Name = "dgvSubordinate";
            this.dgvSubordinate.Size = new System.Drawing.Size(794, 331);
            this.dgvSubordinate.TabIndex = 0;
            this.dgvSubordinate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubordinate_CellContentClick);
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "SubordinateID";
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmName.Width = 200;
            // 
            // tabHobby
            // 
            this.tabHobby.Controls.Add(this.flpHobby);
            this.tabHobby.Location = new System.Drawing.Point(4, 22);
            this.tabHobby.Name = "tabHobby";
            this.tabHobby.Padding = new System.Windows.Forms.Padding(3);
            this.tabHobby.Size = new System.Drawing.Size(800, 337);
            this.tabHobby.TabIndex = 4;
            this.tabHobby.Text = "Hobbies";
            this.tabHobby.UseVisualStyleBackColor = true;
            // 
            // flpHobby
            // 
            this.flpHobby.AutoSize = true;
            this.flpHobby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHobby.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpHobby.Location = new System.Drawing.Point(3, 3);
            this.flpHobby.Name = "flpHobby";
            this.flpHobby.Size = new System.Drawing.Size(794, 331);
            this.flpHobby.TabIndex = 0;
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
            this.ColLastName,
            this.clmDepartment});
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
            // clmDepartment
            // 
            this.clmDepartment.DataPropertyName = "DepartmentId";
            this.clmDepartment.HeaderText = "Department";
            this.clmDepartment.Name = "clmDepartment";
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
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabSEARCH);
            this.tabcontrol1.Controls.Add(this.tabEmployee);
            this.tabcontrol1.Controls.Add(this.tabEmployeePhone);
            this.tabcontrol1.Controls.Add(this.tabEmployeeEmail);
            this.tabcontrol1.Controls.Add(this.tabHobby);
            this.tabcontrol1.Controls.Add(this.tabSubordinate);
            this.tabcontrol1.Controls.Add(this.tabFamily);
            this.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol1.Location = new System.Drawing.Point(0, 24);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(808, 363);
            this.tabcontrol1.TabIndex = 2;
            // 
            // tabFamily
            // 
            this.tabFamily.Controls.Add(this.dgvFamily);
            this.tabFamily.Location = new System.Drawing.Point(4, 22);
            this.tabFamily.Name = "tabFamily";
            this.tabFamily.Padding = new System.Windows.Forms.Padding(3);
            this.tabFamily.Size = new System.Drawing.Size(800, 337);
            this.tabFamily.TabIndex = 6;
            this.tabFamily.Text = "Family Members";
            this.tabFamily.UseVisualStyleBackColor = true;
            // 
            // dgvFamily
            // 
            this.dgvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFamilyName});
            this.dgvFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFamily.Location = new System.Drawing.Point(3, 3);
            this.dgvFamily.Name = "dgvFamily";
            this.dgvFamily.Size = new System.Drawing.Size(794, 331);
            this.dgvFamily.TabIndex = 0;
            // 
            // clmFamilyName
            // 
            this.clmFamilyName.DataPropertyName = "Name";
            this.clmFamilyName.HeaderText = "Name";
            this.clmFamilyName.Name = "clmFamilyName";
            this.clmFamilyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 387);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.mnuEmployeeName);
            this.MainMenuStrip = this.mnuEmployeeName;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuEmployeeName.ResumeLayout(false);
            this.mnuEmployeeName.PerformLayout();
            this.tabSubordinate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinate)).EndInit();
            this.tabHobby.ResumeLayout(false);
            this.tabHobby.PerformLayout();
            this.tabEmployeeEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeEmail)).EndInit();
            this.tabEmployeePhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePhones)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabSEARCH.ResumeLayout(false);
            this.tabcontrol1.ResumeLayout(false);
            this.tabFamily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuEmployeeName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.TabPage tabSubordinate;
        private System.Windows.Forms.DataGridView dgvSubordinate;
        private System.Windows.Forms.TabPage tabHobby;
        private System.Windows.Forms.FlowLayoutPanel flpHobby;
        private System.Windows.Forms.TabPage tabEmployeeEmail;
        private System.Windows.Forms.DataGridView dgvEmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmailType;
        private System.Windows.Forms.TabPage tabEmployeePhone;
        private System.Windows.Forms.DataGridView dgvEmployeePhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhoneType;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDepartment;
        private System.Windows.Forms.TabPage tabSEARCH;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmName;
        private System.Windows.Forms.TabPage tabFamily;
        private System.Windows.Forms.DataGridView dgvFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyName;
    }
}

