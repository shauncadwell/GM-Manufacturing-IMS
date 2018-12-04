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
            this.tableOrderEquip = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtJobCode = new System.Windows.Forms.MaskedTextBox();
            this.lblScanItem = new System.Windows.Forms.Label();
            this.lblJobCode = new System.Windows.Forms.Label();
            this.txtScanItem = new System.Windows.Forms.MaskedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPendingRental = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splMainContainer)).BeginInit();
            this.splMainContainer.Panel1.SuspendLayout();
            this.splMainContainer.Panel2.SuspendLayout();
            this.splMainContainer.SuspendLayout();
            this.tableOrderEquip.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splMainContainer.Panel1.Controls.Add(this.tableOrderEquip);
            this.splMainContainer.Panel1.Controls.Add(this.lblTitle);
            // 
            // splMainContainer.Panel2
            // 
            this.splMainContainer.Panel2.Controls.Add(this.btnSubmitOrder);
            this.splMainContainer.Panel2.Controls.Add(this.panel1);
            this.splMainContainer.Size = new System.Drawing.Size(800, 450);
            this.splMainContainer.SplitterDistance = 266;
            this.splMainContainer.TabIndex = 18;
            // 
            // tableOrderEquip
            // 
            this.tableOrderEquip.ColumnCount = 2;
            this.tableOrderEquip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderEquip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderEquip.Controls.Add(this.btnAddItem, 1, 2);
            this.tableOrderEquip.Controls.Add(this.txtJobCode, 1, 1);
            this.tableOrderEquip.Controls.Add(this.lblScanItem, 0, 0);
            this.tableOrderEquip.Controls.Add(this.lblJobCode, 0, 1);
            this.tableOrderEquip.Controls.Add(this.txtScanItem, 1, 0);
            this.tableOrderEquip.Location = new System.Drawing.Point(12, 78);
            this.tableOrderEquip.Name = "tableOrderEquip";
            this.tableOrderEquip.RowCount = 3;
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderEquip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableOrderEquip.Size = new System.Drawing.Size(226, 108);
            this.tableOrderEquip.TabIndex = 20;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(116, 80);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(107, 23);
            this.btnAddItem.TabIndex = 21;
            this.btnAddItem.TabStop = false;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtJobCode
            // 
            this.txtJobCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobCode.Location = new System.Drawing.Point(116, 47);
            this.txtJobCode.Mask = "00000";
            this.txtJobCode.Name = "txtJobCode";
            this.txtJobCode.Size = new System.Drawing.Size(107, 20);
            this.txtJobCode.TabIndex = 23;
            this.txtJobCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScanItem
            // 
            this.lblScanItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScanItem.AutoSize = true;
            this.lblScanItem.Location = new System.Drawing.Point(3, 12);
            this.lblScanItem.Name = "lblScanItem";
            this.lblScanItem.Size = new System.Drawing.Size(107, 13);
            this.lblScanItem.TabIndex = 19;
            this.lblScanItem.Text = "Scan Item:";
            this.lblScanItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobCode
            // 
            this.lblJobCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobCode.AutoSize = true;
            this.lblJobCode.Location = new System.Drawing.Point(3, 50);
            this.lblJobCode.Name = "lblJobCode";
            this.lblJobCode.Size = new System.Drawing.Size(107, 13);
            this.lblJobCode.TabIndex = 20;
            this.lblJobCode.Text = "Job Code:";
            this.lblJobCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScanItem
            // 
            this.txtScanItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanItem.Location = new System.Drawing.Point(116, 9);
            this.txtScanItem.Mask = "000000";
            this.txtScanItem.Name = "txtScanItem";
            this.txtScanItem.Size = new System.Drawing.Size(107, 20);
            this.txtScanItem.TabIndex = 22;
            this.txtScanItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 36);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Order Equipment";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(420, 415);
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
            this.panel1.Controls.Add(this.dgvPendingRental);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 395);
            this.panel1.TabIndex = 0;
            // 
            // dgvPendingRental
            // 
            this.dgvPendingRental.AllowUserToAddRows = false;
            this.dgvPendingRental.AllowUserToResizeColumns = false;
            this.dgvPendingRental.AllowUserToResizeRows = false;
            this.dgvPendingRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPendingRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendingRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendingRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendingRental.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPendingRental.Location = new System.Drawing.Point(0, 0);
            this.dgvPendingRental.MultiSelect = false;
            this.dgvPendingRental.Name = "dgvPendingRental";
            this.dgvPendingRental.RowHeadersVisible = false;
            this.dgvPendingRental.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPendingRental.RowTemplate.ReadOnly = true;
            this.dgvPendingRental.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingRental.Size = new System.Drawing.Size(527, 395);
            this.dgvPendingRental.TabIndex = 0;
            this.dgvPendingRental.TabStop = false;
            // 
            // OrderEquipment
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splMainContainer);
            this.Name = "OrderEquipment";
            this.Text = "OrderEquipment";
            this.Load += new System.EventHandler(this.OrderEquipment_Load);
            this.splMainContainer.Panel1.ResumeLayout(false);
            this.splMainContainer.Panel1.PerformLayout();
            this.splMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMainContainer)).EndInit();
            this.splMainContainer.ResumeLayout(false);
            this.tableOrderEquip.ResumeLayout(false);
            this.tableOrderEquip.PerformLayout();
            this.panel1.ResumeLayout(false);
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
    }
}