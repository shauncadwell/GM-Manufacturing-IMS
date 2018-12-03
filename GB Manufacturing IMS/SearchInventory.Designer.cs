namespace GB_Manufacturing_IMS
{
    partial class SearchInventory
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.searchTable = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbSelectTable = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(58, 180);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(195, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(11, 183);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(48, 13);
            this.lblKeyword.TabIndex = 2;
            this.lblKeyword.Text = "Keyword";
            // 
            // searchTable
            // 
            this.searchTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTable.Location = new System.Drawing.Point(0, 0);
            this.searchTable.Name = "searchTable";
            this.searchTable.ReadOnly = true;
            this.searchTable.Size = new System.Drawing.Size(703, 454);
            this.searchTable.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(58, 206);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubimit);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblError);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblSelect);
            this.splitContainer1.Panel1.Controls.Add(this.cbSelectTable);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.txtKeyword);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.lblKeyword);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchTable);
            this.splitContainer1.Size = new System.Drawing.Size(973, 454);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Inventory";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(15, 156);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(37, 13);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Select";
            // 
            // cbSelectTable
            // 
            this.cbSelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectTable.FormattingEnabled = true;
            this.cbSelectTable.Items.AddRange(new object[] {
            "Materials",
            "Equipment"});
            this.cbSelectTable.Location = new System.Drawing.Point(58, 153);
            this.cbSelectTable.Name = "cbSelectTable";
            this.cbSelectTable.Size = new System.Drawing.Size(195, 21);
            this.cbSelectTable.TabIndex = 5;
            this.cbSelectTable.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(113, 48);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(55, 232);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            // 
            // SearchInventory
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 454);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchInventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.DataGridView searchTable;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbSelectTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblError;
    }
}