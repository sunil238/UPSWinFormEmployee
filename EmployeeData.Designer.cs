namespace EmployeeDetails
{
    partial class EmployeeData
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
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.pnlAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.Controls.Add(this.comboGender);
            this.pnlAddEmployee.Controls.Add(this.btnSave);
            this.pnlAddEmployee.Controls.Add(this.chkActive);
            this.pnlAddEmployee.Controls.Add(this.lblGender);
            this.pnlAddEmployee.Controls.Add(this.txtEmail);
            this.pnlAddEmployee.Controls.Add(this.lblEmail);
            this.pnlAddEmployee.Controls.Add(this.txtName);
            this.pnlAddEmployee.Controls.Add(this.lblName);
            this.pnlAddEmployee.Location = new System.Drawing.Point(12, 504);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(494, 266);
            this.pnlAddEmployee.TabIndex = 0;
            // 
            // comboGender
            // 
            this.comboGender.DisplayMember = "Male";
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(214, 115);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(182, 33);
            this.comboGender.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(41, 164);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(98, 29);
            this.chkActive.TabIndex = 16;
            this.chkActive.Text = "isActive";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(31, 118);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(161, 25);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Select your Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 31);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 80);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 33;
            this.dgvEmployee.Size = new System.Drawing.Size(582, 337);
            this.dgvEmployee.TabIndex = 20;
            this.dgvEmployee.MultiSelectChanged += new System.EventHandler(this.dgvEmployee_MultiSelectChanged);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(174, 33);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(112, 34);
            this.btnSearchUser.TabIndex = 22;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(12, 33);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(150, 31);
            this.txtSearchUser.TabIndex = 23;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(601, 343);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 34);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export ";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(601, 274);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(112, 34);
            this.btnDeleteRow.TabIndex = 25;
            this.btnDeleteRow.Text = "Delete Selected Rows";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // EmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 782);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlAddEmployee);
            this.Name = "EmployeeData";
            this.Text = "EmployeeData";
            this.Load += new System.EventHandler(this.EmployeeData_Load);
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlAddEmployee;
        private ComboBox comboGender;
        private Button btnSave;
        private CheckBox chkActive;
        private Label lblGender;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtName;
        private Label lblName;
        private Button btnAdd;
        private DataGridView dgvEmployee;
        private Button btnSearchUser;
        private TextBox txtSearchUser;
        private Button btnExport;
        private Button btnDeleteRow;
    }
}