namespace GB_Manufacturing_IMS
{
    partial class OrderEquipment
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
            this.splMainContainer = new System.Windows.Forms.SplitContainer();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.tableOrderEquip = new System.Windows.Forms.TableLayoutPanel();
            this.txtJobCode = new System.Windows.Forms.MaskedTextBox();
            this.lblScanItem = new System.Windows.Forms.Label();
            this.lblJobCode = new System.Windows.Forms.Label();
            this.txtScanItem = new System.Windows.Forms.MaskedTextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seperator = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.dgvPendingRental = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splMainContainer)).BeginInit();
            this.splMainContainer.Panel1.SuspendLayout();
            this.splMainContainer.Panel2.SuspendLayout();
            this.splMainContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableOrderEquip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRental)).BeginInit();
            this.SuspendLayout();
            // 
            // splMainContainer
            // 
            this.splMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splMainContainer.IsSplitterFixed = true;
            this.splMainContainer.Location = new System.Drawing.Point(0, 0);
            this.splMainContainer.Name = "splMainContainer";
            // 
            // splMainContainer.Panel1
            // 
            this.splMainContainer.Panel1.Controls.Add(this.btnClearOrder);
            this.splMainContainer.Panel1.Controls.Add(this.groupBox1);
            this.splMainContainer.Panel1.Controls.Add(this.tableOrderEquip);
            this.splMainContainer.Panel1.Controls.Add(this.lblTitle);
            // 
            // splMainContainer.Panel2
            // 
            this.splMainContainer.Panel2.Controls.Add(this.btnSubmitOrder);
            this.splMainContainer.Panel2.Controls.Add(this.panel1);
            this.splMainContainer.Panel2.Controls.Add(this.button1);
            this.splMainContainer.Size = new System.Drawing.Size(815, 565);
            this.splMainContainer.SplitterDistance = 266;
            this.splMainContainer.TabIndex = 18;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(79, 337);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(116, 39);
            this.btnClearOrder.TabIndex = 23;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInformation);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 145);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformation.Location = new System.Drawing.Point(3, 16);
            this.lblInformation.MaximumSize = new System.Drawing.Size(175, 150);
            this.lblInformation.MinimumSize = new System.Drawing.Size(100, 100);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(100, 100);
            this.lblInformation.TabIndex = 21;
            // 
            // tableOrderEquip
            // 
            this.tableOrderEquip.ColumnCount = 2;
            this.tableOrderEquip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableOrderEquip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableOrderEquip.Controls.Add(this.txtJobCode, 1, 0);
            this.tableOrderEquip.Controls.Add(this.lblScanItem, 0, 1);
            this.tableOrderEquip.Controls.Add(this.lblJobCode, 0, 0);
            this.tableOrderEquip.Controls.Add(this.txtScanItem, 1, 1);
            this.tableOrderEquip.Controls.Add(this.btnAddItem, 1, 3);
            this.tableOrderEquip.Controls.Add(this.txtQuantity, 1, 2);
            this.tableOrderEquip.Controls.Add(this.label1, 0, 2);
            this.tableOrderEquip.Location = new System.Drawing.Point(12, 214);
            this.tableOrderEquip.Name = "tableOrderEquip";
            this.tableOrderEquip.RowCount = 4;
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableOrderEquip.Size = new System.Drawing.Size(183, 117);
            this.tableOrderEquip.TabIndex = 20;
            // 
            // txtJobCode
            // 
            this.txtJobCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobCode.Location = new System.Drawing.Point(67, 3);
            this.txtJobCode.Mask = "00000";
            this.txtJobCode.Name = "txtJobCode";
            this.txtJobCode.Size = new System.Drawing.Size(113, 20);
            this.txtJobCode.TabIndex = 1;
            this.txtJobCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScanItem
            // 
            this.lblScanItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScanItem.AutoSize = true;
            this.lblScanItem.Location = new System.Drawing.Point(3, 32);
            this.lblScanItem.Name = "lblScanItem";
            this.lblScanItem.Size = new System.Drawing.Size(58, 13);
            this.lblScanItem.TabIndex = 19;
            this.lblScanItem.Text = "Scan Item:";
            this.lblScanItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobCode
            // 
            this.lblJobCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobCode.AutoSize = true;
            this.lblJobCode.Location = new System.Drawing.Point(3, 6);
            this.lblJobCode.Name = "lblJobCode";
            this.lblJobCode.Size = new System.Drawing.Size(58, 13);
            this.lblJobCode.TabIndex = 20;
            this.lblJobCode.Text = "Job Code:";
            this.lblJobCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScanItem
            // 
            this.txtScanItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanItem.Location = new System.Drawing.Point(67, 29);
            this.txtScanItem.Mask = "000000";
            this.txtScanItem.Name = "txtScanItem";
            this.txtScanItem.Size = new System.Drawing.Size(113, 20);
            this.txtScanItem.TabIndex = 2;
            this.txtScanItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(67, 85);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(113, 25);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(67, 55);
            this.txtQuantity.Mask = "000000";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(113, 20);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 36);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Equipment Rental";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(435, 530);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(98, 23);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.TabStop = false;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.seperator);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvSearch);
            this.panel1.Controls.Add(this.dgvPendingRental);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pending Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "Warehouse 1 - Search";
            // 
            // seperator
            // 
            this.seperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seperator.Location = new System.Drawing.Point(0, 249);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(542, 10);
            this.seperator.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(320, 216);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 214);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSearch.Location = new System.Drawing.Point(3, 48);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSearch.RowTemplate.ReadOnly = true;
            this.dgvSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(537, 160);
            this.dgvSearch.TabIndex = 1;
            this.dgvSearch.TabStop = false;
            // 
            // dgvPendingRental
            // 
            this.dgvPendingRental.AllowUserToAddRows = false;
            this.dgvPendingRental.AllowUserToResizeColumns = false;
            this.dgvPendingRental.AllowUserToResizeRows = false;
            this.dgvPendingRental.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPendingRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendingRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendingRental.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPendingRental.Location = new System.Drawing.Point(0, 315);
            this.dgvPendingRental.MultiSelect = false;
            this.dgvPendingRental.Name = "dgvPendingRental";
            this.dgvPendingRental.RowHeadersVisible = false;
            this.dgvPendingRental.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPendingRental.RowTemplate.ReadOnly = true;
            this.dgvPendingRental.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingRental.Size = new System.Drawing.Size(540, 192);
            this.dgvPendingRental.TabIndex = 0;
            this.dgvPendingRental.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrderEquipment
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 565);
            this.Controls.Add(this.splMainContainer);
            this.Name = "OrderEquipment";
            this.Text = "OrderEquipment";
            this.Load += new System.EventHandler(this.OrderEquipment_Load);
            this.splMainContainer.Panel1.ResumeLayout(false);
            this.splMainContainer.Panel1.PerformLayout();
            this.splMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMainContainer)).EndInit();
            this.splMainContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableOrderEquip.ResumeLayout(false);
            this.tableOrderEquip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splMainContainer;
        private System.Windows.Forms.TableLayoutPanel tableOrderEquip;
        private System.Windows.Forms.Label lblScanItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblJobCode;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPendingRental;
        private System.Windows.Forms.MaskedTextBox txtScanItem;
        private System.Windows.Forms.MaskedTextBox txtJobCode;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel seperator;
    }
}