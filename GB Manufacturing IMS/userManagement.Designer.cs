//Mission Critical
//MD5 Password
//

namespace GB_Manufacturing_IMS
{
    partial class userManagement
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
            this.employeeTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSearchEmployees = new System.Windows.Forms.DataGridView();
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEditUsername = new System.Windows.Forms.LinkLabel();
            this.lnkEditLast = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lnkEditFirst = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lnkEditStatus = new System.Windows.Forms.LinkLabel();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.lnkEditRank = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetPw = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tblSearchEmp = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAddRank = new System.Windows.Forms.ComboBox();
            this.groupInitial = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.tblPersonalInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddFName = new System.Windows.Forms.TextBox();
            this.txtAddLName = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbNewStatus = new System.Windows.Forms.ComboBox();
            this.employeeTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployees)).BeginInit();
            this.grpEmployeeInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblSearchEmp.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupInitial.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupPersonal.SuspendLayout();
            this.tblPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTabs
            // 
            this.employeeTabs.Controls.Add(this.tabPage1);
            this.employeeTabs.Controls.Add(this.tabPage2);
            this.employeeTabs.Location = new System.Drawing.Point(12, 13);
            this.employeeTabs.Name = "employeeTabs";
            this.employeeTabs.SelectedIndex = 0;
            this.employeeTabs.Size = new System.Drawing.Size(683, 407);
            this.employeeTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dgvSearchEmployees);
            this.tabPage1.Controls.Add(this.grpEmployeeInfo);
            this.tabPage1.Controls.Add(this.tblSearchEmp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update User Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 33);
            this.label10.TabIndex = 25;
            this.label10.Text = "Update Existing User";
            // 
            // dgvSearchEmployees
            // 
            this.dgvSearchEmployees.AllowUserToAddRows = false;
            this.dgvSearchEmployees.AllowUserToDeleteRows = false;
            this.dgvSearchEmployees.AllowUserToResizeColumns = false;
            this.dgvSearchEmployees.AllowUserToResizeRows = false;
            this.dgvSearchEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEmployees.Location = new System.Drawing.Point(308, 3);
            this.dgvSearchEmployees.MultiSelect = false;
            this.dgvSearchEmployees.Name = "dgvSearchEmployees";
            this.dgvSearchEmployees.ReadOnly = true;
            this.dgvSearchEmployees.RowHeadersVisible = false;
            this.dgvSearchEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchEmployees.Size = new System.Drawing.Size(367, 375);
            this.dgvSearchEmployees.TabIndex = 8;
            this.dgvSearchEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchEmployees_CellClick);
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.tableLayoutPanel2);
            this.grpEmployeeInfo.Location = new System.Drawing.Point(12, 80);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(290, 295);
            this.grpEmployeeInfo.TabIndex = 7;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Employee Information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblEditUsername, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lnkEditLast, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtFirst, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLast, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lnkEditFirst, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cboStatus, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lnkEditStatus, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbRank, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lnkEditRank, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnResetPw, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 276);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblEditUsername
            // 
            this.lblEditUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEditUsername.AutoSize = true;
            this.lblEditUsername.Location = new System.Drawing.Point(255, 106);
            this.lblEditUsername.Name = "lblEditUsername";
            this.lblEditUsername.Size = new System.Drawing.Size(25, 13);
            this.lblEditUsername.TabIndex = 16;
            this.lblEditUsername.TabStop = true;
            this.lblEditUsername.Text = "Edit";
            this.lblEditUsername.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditUsername_LinkClicked);
            // 
            // lnkEditLast
            // 
            this.lnkEditLast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkEditLast.AutoSize = true;
            this.lnkEditLast.Location = new System.Drawing.Point(255, 61);
            this.lnkEditLast.Name = "lnkEditLast";
            this.lnkEditLast.Size = new System.Drawing.Size(25, 13);
            this.lnkEditLast.TabIndex = 9;
            this.lnkEditLast.TabStop = true;
            this.lnkEditLast.Text = "Edit";
            this.lnkEditLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditLast_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirst
            // 
            this.txtFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirst.Enabled = false;
            this.txtFirst.Location = new System.Drawing.Point(129, 12);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(120, 20);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.TabStop = false;
            // 
            // txtLast
            // 
            this.txtLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLast.Enabled = false;
            this.txtLast.Location = new System.Drawing.Point(129, 57);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(120, 20);
            this.txtLast.TabIndex = 3;
            this.txtLast.TabStop = false;
            // 
            // lnkEditFirst
            // 
            this.lnkEditFirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkEditFirst.AutoSize = true;
            this.lnkEditFirst.Location = new System.Drawing.Point(255, 16);
            this.lnkEditFirst.Name = "lnkEditFirst";
            this.lnkEditFirst.Size = new System.Drawing.Size(25, 13);
            this.lnkEditFirst.TabIndex = 8;
            this.lnkEditFirst.TabStop = true;
            this.lnkEditFirst.Text = "Edit";
            this.lnkEditFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditFirst_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(129, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employment Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Enabled = false;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Suspended",
            "Terminated"});
            this.cboStatus.Location = new System.Drawing.Point(129, 192);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(120, 21);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.TabStop = false;
            this.cboStatus.DisplayMemberChanged += new System.EventHandler(this.cboStatus_DisplayMemberChanged);
            // 
            // lnkEditStatus
            // 
            this.lnkEditStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkEditStatus.AutoSize = true;
            this.lnkEditStatus.Location = new System.Drawing.Point(255, 196);
            this.lnkEditStatus.Name = "lnkEditStatus";
            this.lnkEditStatus.Size = new System.Drawing.Size(25, 13);
            this.lnkEditStatus.TabIndex = 11;
            this.lnkEditStatus.TabStop = true;
            this.lnkEditStatus.Text = "Edit";
            this.lnkEditStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditStatus_LinkClicked);
            // 
            // cbRank
            // 
            this.cbRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.Enabled = false;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRank.Location = new System.Drawing.Point(129, 147);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(120, 21);
            this.cbRank.TabIndex = 12;
            this.cbRank.TabStop = false;
            // 
            // lnkEditRank
            // 
            this.lnkEditRank.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkEditRank.AutoSize = true;
            this.lnkEditRank.Location = new System.Drawing.Point(255, 151);
            this.lnkEditRank.Name = "lnkEditRank";
            this.lnkEditRank.Size = new System.Drawing.Size(25, 13);
            this.lnkEditRank.TabIndex = 10;
            this.lnkEditRank.TabStop = true;
            this.lnkEditRank.Text = "Edit";
            this.lnkEditRank.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditRank_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rank";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnResetPw
            // 
            this.btnResetPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPw.Enabled = false;
            this.btnResetPw.Location = new System.Drawing.Point(3, 239);
            this.btnResetPw.Name = "btnResetPw";
            this.btnResetPw.Size = new System.Drawing.Size(120, 23);
            this.btnResetPw.TabIndex = 14;
            this.btnResetPw.TabStop = false;
            this.btnResetPw.Text = "Reset Password";
            this.btnResetPw.UseVisualStyleBackColor = true;
            this.btnResetPw.Click += new System.EventHandler(this.btnResetPw_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(129, 102);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(120, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TabStop = false;
            // 
            // tblSearchEmp
            // 
            this.tblSearchEmp.ColumnCount = 2;
            this.tblSearchEmp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblSearchEmp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tblSearchEmp.Controls.Add(this.lblID, 0, 0);
            this.tblSearchEmp.Controls.Add(this.txtSearchEmployee, 1, 0);
            this.tblSearchEmp.Location = new System.Drawing.Point(12, 44);
            this.tblSearchEmp.Name = "tblSearchEmp";
            this.tblSearchEmp.RowCount = 1;
            this.tblSearchEmp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearchEmp.Size = new System.Drawing.Size(258, 30);
            this.tblSearchEmp.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Search Employee:";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(103, 5);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(152, 20);
            this.txtSearchEmployee.TabIndex = 1;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupInfo);
            this.tabPage2.Controls.Add(this.lblAddNew);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupInitial);
            this.tabPage2.Controls.Add(this.groupPersonal);
            this.tabPage2.Controls.Add(this.btnAddNewUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.lblAddNew.Location = new System.Drawing.Point(7, 3);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(194, 34);
            this.lblAddNew.TabIndex = 24;
            this.lblAddNew.Text = "Add New User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Location = new System.Drawing.Point(13, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 92);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employment Information";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbAddRank, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStatus, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbNewStatus, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 73);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Employment Rank";
            // 
            // cbAddRank
            // 
            this.cbAddRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddRank.FormattingEnabled = true;
            this.cbAddRank.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAddRank.Location = new System.Drawing.Point(131, 7);
            this.cbAddRank.Name = "cbAddRank";
            this.cbAddRank.Size = new System.Drawing.Size(123, 21);
            this.cbAddRank.TabIndex = 3;
            // 
            // groupInitial
            // 
            this.groupInitial.Controls.Add(this.tableLayoutPanel3);
            this.groupInitial.Location = new System.Drawing.Point(13, 242);
            this.groupInitial.Name = "groupInitial";
            this.groupInitial.Size = new System.Drawing.Size(263, 92);
            this.groupInitial.TabIndex = 22;
            this.groupInitial.TabStop = false;
            this.groupInitial.Text = "Initial Credentials";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtAddUsername, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtAddPassword, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 73);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddUsername.Location = new System.Drawing.Point(131, 8);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(123, 20);
            this.txtAddUsername.TabIndex = 5;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPassword.Location = new System.Drawing.Point(131, 44);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(123, 20);
            this.txtAddPassword.TabIndex = 6;
            // 
            // groupPersonal
            // 
            this.groupPersonal.Controls.Add(this.tblPersonalInfo);
            this.groupPersonal.Location = new System.Drawing.Point(13, 44);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Size = new System.Drawing.Size(263, 92);
            this.groupPersonal.TabIndex = 21;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "Personal Information";
            // 
            // tblPersonalInfo
            // 
            this.tblPersonalInfo.ColumnCount = 2;
            this.tblPersonalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.Controls.Add(this.lblFirstName, 0, 0);
            this.tblPersonalInfo.Controls.Add(this.lblLastName, 0, 1);
            this.tblPersonalInfo.Controls.Add(this.txtAddFName, 1, 0);
            this.tblPersonalInfo.Controls.Add(this.txtAddLName, 1, 1);
            this.tblPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPersonalInfo.Location = new System.Drawing.Point(3, 16);
            this.tblPersonalInfo.Name = "tblPersonalInfo";
            this.tblPersonalInfo.RowCount = 2;
            this.tblPersonalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPersonalInfo.Size = new System.Drawing.Size(257, 73);
            this.tblPersonalInfo.TabIndex = 20;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 11);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(122, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtAddFName
            // 
            this.txtAddFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddFName.Location = new System.Drawing.Point(131, 8);
            this.txtAddFName.Name = "txtAddFName";
            this.txtAddFName.Size = new System.Drawing.Size(123, 20);
            this.txtAddFName.TabIndex = 1;
            // 
            // txtAddLName
            // 
            this.txtAddLName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddLName.Location = new System.Drawing.Point(131, 44);
            this.txtAddLName.Name = "txtAddLName";
            this.txtAddLName.Size = new System.Drawing.Size(123, 20);
            this.txtAddLName.TabIndex = 2;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(159, 340);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(117, 23);
            this.btnAddNewUser.TabIndex = 6;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // groupInfo
            // 
            this.groupInfo.Location = new System.Drawing.Point(349, 44);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(301, 138);
            this.groupInfo.TabIndex = 25;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Info Box";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Employment Status";
            // 
            // cbNewStatus
            // 
            this.cbNewStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewStatus.FormattingEnabled = true;
            this.cbNewStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Suspended",
            "Terminated"});
            this.cbNewStatus.Location = new System.Drawing.Point(131, 44);
            this.cbNewStatus.Name = "cbNewStatus";
            this.cbNewStatus.Size = new System.Drawing.Size(123, 21);
            this.cbNewStatus.TabIndex = 4;
            // 
            // userManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 432);
            this.Controls.Add(this.employeeTabs);
            this.Name = "userManagement";
            this.Text = "User Management";
            this.employeeTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployees)).EndInit();
            this.grpEmployeeInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblSearchEmp.ResumeLayout(false);
            this.tblSearchEmp.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupInitial.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupPersonal.ResumeLayout(false);
            this.tblPersonalInfo.ResumeLayout(false);
            this.tblPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl employeeTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAddLName;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox txtAddFName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TableLayoutPanel tblSearchEmp;
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel lnkEditStatus;
        private System.Windows.Forms.LinkLabel lnkEditRank;
        private System.Windows.Forms.LinkLabel lnkEditLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.LinkLabel lnkEditFirst;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAddRank;
        private System.Windows.Forms.GroupBox groupInitial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.TableLayoutPanel tblPersonalInfo;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.DataGridView dgvSearchEmployees;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.LinkLabel lblEditUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetPw;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbNewStatus;
    }
}