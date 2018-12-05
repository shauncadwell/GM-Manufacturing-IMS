namespace GB_Manufacturing_IMS
{
    partial class NewOrder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLbl = new System.Windows.Forms.Label();
            this.itemNumber = new System.Windows.Forms.MaskedTextBox();
            this.jobCode = new System.Windows.Forms.MaskedTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.itemValidityMessage = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.itemNumberLbl = new System.Windows.Forms.Label();
            this.jobCodeLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitOrderBtn = new System.Windows.Forms.Button();
            this.orderContentsLbl = new System.Windows.Forms.Label();
            this.itemQuantity = new System.Windows.Forms.MaskedTextBox();
            this.orderSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.itemQuantity);
            this.splitContainer1.Panel1.Controls.Add(this.titleLbl);
            this.splitContainer1.Panel1.Controls.Add(this.itemNumber);
            this.splitContainer1.Panel1.Controls.Add(this.jobCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.itemValidityMessage);
            this.splitContainer1.Panel1.Controls.Add(this.addItemBtn);
            this.splitContainer1.Panel1.Controls.Add(this.quantityLbl);
            this.splitContainer1.Panel1.Controls.Add(this.itemNumberLbl);
            this.splitContainer1.Panel1.Controls.Add(this.jobCodeLbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.orderSummary);
            this.splitContainer1.Panel2.Controls.Add(this.cancelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.submitOrderBtn);
            this.splitContainer1.Panel2.Controls.Add(this.orderContentsLbl);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(62, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(143, 24);
            this.titleLbl.TabIndex = 17;
            this.titleLbl.Text = "Material Order";
            // 
            // itemNumber
            // 
            this.itemNumber.Location = new System.Drawing.Point(131, 93);
            this.itemNumber.Mask = "000000";
            this.itemNumber.Name = "itemNumber";
            this.itemNumber.Size = new System.Drawing.Size(120, 20);
            this.itemNumber.TabIndex = 2;
            this.itemNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemNumber.TextChanged += new System.EventHandler(this.itemNumber_TextChanged);
            // 
            // jobCode
            // 
            this.jobCode.Location = new System.Drawing.Point(130, 56);
            this.jobCode.Mask = "00000";
            this.jobCode.Name = "jobCode";
            this.jobCode.Size = new System.Drawing.Size(121, 20);
            this.jobCode.TabIndex = 1;
            this.jobCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(70, 241);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // itemValidityMessage
            // 
            this.itemValidityMessage.AutoSize = true;
            this.itemValidityMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.itemValidityMessage.Location = new System.Drawing.Point(139, 116);
            this.itemValidityMessage.Name = "itemValidityMessage";
            this.itemValidityMessage.Size = new System.Drawing.Size(101, 13);
            this.itemValidityMessage.TabIndex = 15;
            this.itemValidityMessage.Text = "Invalid Item Number";
            this.itemValidityMessage.Visible = false;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Enabled = false;
            this.addItemBtn.Location = new System.Drawing.Point(94, 165);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(15, 135);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 7;
            this.quantityLbl.Text = "Quantity:";
            // 
            // itemNumberLbl
            // 
            this.itemNumberLbl.AutoSize = true;
            this.itemNumberLbl.Location = new System.Drawing.Point(15, 96);
            this.itemNumberLbl.Name = "itemNumberLbl";
            this.itemNumberLbl.Size = new System.Drawing.Size(70, 13);
            this.itemNumberLbl.TabIndex = 5;
            this.itemNumberLbl.Text = "Item Number:";
            // 
            // jobCodeLbl
            // 
            this.jobCodeLbl.AutoSize = true;
            this.jobCodeLbl.Location = new System.Drawing.Point(15, 60);
            this.jobCodeLbl.Name = "jobCodeLbl";
            this.jobCodeLbl.Size = new System.Drawing.Size(55, 13);
            this.jobCodeLbl.TabIndex = 4;
            this.jobCodeLbl.Text = "Job Code:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(277, 361);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitOrderBtn
            // 
            this.submitOrderBtn.Enabled = false;
            this.submitOrderBtn.Location = new System.Drawing.Point(143, 361);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(102, 23);
            this.submitOrderBtn.TabIndex = 6;
            this.submitOrderBtn.Text = "Submit Order";
            this.submitOrderBtn.UseVisualStyleBackColor = true;
            this.submitOrderBtn.Click += new System.EventHandler(this.submitOrderBtn_Click);
            // 
            // orderContentsLbl
            // 
            this.orderContentsLbl.AutoSize = true;
            this.orderContentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderContentsLbl.Location = new System.Drawing.Point(225, 9);
            this.orderContentsLbl.Name = "orderContentsLbl";
            this.orderContentsLbl.Size = new System.Drawing.Size(92, 13);
            this.orderContentsLbl.TabIndex = 1;
            this.orderContentsLbl.Text = "Order Summary";
            // 
            // itemQuantity
            // 
            this.itemQuantity.Location = new System.Drawing.Point(130, 139);
            this.itemQuantity.Mask = "000";
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(121, 20);
            this.itemQuantity.TabIndex = 3;
            this.itemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderSummary
            // 
            this.orderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderSummary.Location = new System.Drawing.Point(29, 56);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(472, 274);
            this.orderSummary.TabIndex = 8;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label itemNumberLbl;
        private System.Windows.Forms.Label jobCodeLbl;
        private System.Windows.Forms.Label orderContentsLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitOrderBtn;
        private System.Windows.Forms.Label itemValidityMessage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MaskedTextBox jobCode;
        private System.Windows.Forms.MaskedTextBox itemNumber;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.MaskedTextBox itemQuantity;
        private System.Windows.Forms.DataGridView orderSummary;
    }
}