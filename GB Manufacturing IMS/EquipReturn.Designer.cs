namespace GB_Manufacturing_IMS
{
    partial class EquipReturn
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
            this.lblReturnTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReturnStatus = new System.Windows.Forms.Label();
            this.lblReturnItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.txtReturnItem = new System.Windows.Forms.TextBox();
            this.btnReturnSubmit = new System.Windows.Forms.Button();
            this.lblRetItemChk = new System.Windows.Forms.Label();
            this.lblReturnStatChk = new System.Windows.Forms.Label();
            this.lblReturnJob = new System.Windows.Forms.Label();
            this.lblChkBox1 = new System.Windows.Forms.Label();
            this.lblChkBox2 = new System.Windows.Forms.Label();
            this.lblChkBox3 = new System.Windows.Forms.Label();
            this.btnReturnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReturnTitle
            // 
            this.lblReturnTitle.AutoSize = true;
            this.lblReturnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTitle.Location = new System.Drawing.Point(26, 18);
            this.lblReturnTitle.Name = "lblReturnTitle";
            this.lblReturnTitle.Size = new System.Drawing.Size(318, 42);
            this.lblReturnTitle.TabIndex = 0;
            this.lblReturnTitle.Text = "Equipment Return";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturnSubmit);
            this.groupBox1.Controls.Add(this.txtReturnItem);
            this.groupBox1.Controls.Add(this.comboStatus);
            this.groupBox1.Controls.Add(this.lblReturnItem);
            this.groupBox1.Controls.Add(this.lblReturnStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Return Details";
            // 
            // lblReturnStatus
            // 
            this.lblReturnStatus.AutoSize = true;
            this.lblReturnStatus.Location = new System.Drawing.Point(19, 37);
            this.lblReturnStatus.Name = "lblReturnStatus";
            this.lblReturnStatus.Size = new System.Drawing.Size(90, 16);
            this.lblReturnStatus.TabIndex = 0;
            this.lblReturnStatus.Text = "Status of Item:";
            // 
            // lblReturnItem
            // 
            this.lblReturnItem.AutoSize = true;
            this.lblReturnItem.Location = new System.Drawing.Point(24, 83);
            this.lblReturnItem.Name = "lblReturnItem";
            this.lblReturnItem.Size = new System.Drawing.Size(87, 16);
            this.lblReturnItem.TabIndex = 1;
            this.lblReturnItem.Text = "Item Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please make sure all equipment is return in working order.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipment needs to be cleaned and ready to use when checked in.";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "In Stock",
            "Shrink",
            "Lost"});
            this.comboStatus.Location = new System.Drawing.Point(120, 34);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(142, 24);
            this.comboStatus.TabIndex = 2;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // txtReturnItem
            // 
            this.txtReturnItem.Location = new System.Drawing.Point(119, 80);
            this.txtReturnItem.Name = "txtReturnItem";
            this.txtReturnItem.Size = new System.Drawing.Size(143, 22);
            this.txtReturnItem.TabIndex = 3;
            // 
            // btnReturnSubmit
            // 
            this.btnReturnSubmit.Location = new System.Drawing.Point(187, 199);
            this.btnReturnSubmit.Name = "btnReturnSubmit";
            this.btnReturnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnReturnSubmit.TabIndex = 4;
            this.btnReturnSubmit.Text = "Check In";
            this.btnReturnSubmit.UseVisualStyleBackColor = true;
            this.btnReturnSubmit.Click += new System.EventHandler(this.btnReturnSubmit_Click);
            // 
            // lblRetItemChk
            // 
            this.lblRetItemChk.AutoSize = true;
            this.lblRetItemChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetItemChk.Location = new System.Drawing.Point(329, 160);
            this.lblRetItemChk.Name = "lblRetItemChk";
            this.lblRetItemChk.Size = new System.Drawing.Size(87, 16);
            this.lblRetItemChk.TabIndex = 6;
            this.lblRetItemChk.Text = "Item Number:";
            // 
            // lblReturnStatChk
            // 
            this.lblReturnStatChk.AutoSize = true;
            this.lblReturnStatChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnStatChk.Location = new System.Drawing.Point(324, 114);
            this.lblReturnStatChk.Name = "lblReturnStatChk";
            this.lblReturnStatChk.Size = new System.Drawing.Size(90, 16);
            this.lblReturnStatChk.TabIndex = 5;
            this.lblReturnStatChk.Text = "Status of Item:";
            // 
            // lblReturnJob
            // 
            this.lblReturnJob.AutoSize = true;
            this.lblReturnJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnJob.Location = new System.Drawing.Point(344, 204);
            this.lblReturnJob.Name = "lblReturnJob";
            this.lblReturnJob.Size = new System.Drawing.Size(70, 16);
            this.lblReturnJob.TabIndex = 7;
            this.lblReturnJob.Text = "Job Code:";
            // 
            // lblChkBox1
            // 
            this.lblChkBox1.AutoSize = true;
            this.lblChkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkBox1.Location = new System.Drawing.Point(441, 114);
            this.lblChkBox1.Name = "lblChkBox1";
            this.lblChkBox1.Size = new System.Drawing.Size(17, 16);
            this.lblChkBox1.TabIndex = 8;
            this.lblChkBox1.Text = "...";
            // 
            // lblChkBox2
            // 
            this.lblChkBox2.AutoSize = true;
            this.lblChkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkBox2.Location = new System.Drawing.Point(441, 160);
            this.lblChkBox2.Name = "lblChkBox2";
            this.lblChkBox2.Size = new System.Drawing.Size(17, 16);
            this.lblChkBox2.TabIndex = 9;
            this.lblChkBox2.Text = "...";
            // 
            // lblChkBox3
            // 
            this.lblChkBox3.AutoSize = true;
            this.lblChkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChkBox3.Location = new System.Drawing.Point(441, 204);
            this.lblChkBox3.Name = "lblChkBox3";
            this.lblChkBox3.Size = new System.Drawing.Size(17, 16);
            this.lblChkBox3.TabIndex = 10;
            this.lblChkBox3.Text = "...";
            // 
            // btnReturnConfirm
            // 
            this.btnReturnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnConfirm.Location = new System.Drawing.Point(490, 276);
            this.btnReturnConfirm.Name = "btnReturnConfirm";
            this.btnReturnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnReturnConfirm.TabIndex = 5;
            this.btnReturnConfirm.Text = "Confirm";
            this.btnReturnConfirm.UseVisualStyleBackColor = true;
            this.btnReturnConfirm.Click += new System.EventHandler(this.btnReturnConfirm_Click);
            // 
            // EquipReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 418);
            this.Controls.Add(this.btnReturnConfirm);
            this.Controls.Add(this.lblChkBox3);
            this.Controls.Add(this.lblChkBox2);
            this.Controls.Add(this.lblChkBox1);
            this.Controls.Add(this.lblReturnJob);
            this.Controls.Add(this.lblRetItemChk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReturnStatChk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblReturnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EquipReturn";
            this.Text = "EquipmentReturn";
            this.Load += new System.EventHandler(this.EquipReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReturnItem;
        private System.Windows.Forms.Label lblReturnStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturnSubmit;
        private System.Windows.Forms.TextBox txtReturnItem;
        private System.Windows.Forms.Label lblRetItemChk;
        private System.Windows.Forms.Label lblReturnStatChk;
        private System.Windows.Forms.Label lblReturnJob;
        private System.Windows.Forms.Label lblChkBox1;
        private System.Windows.Forms.Label lblChkBox2;
        private System.Windows.Forms.Label lblChkBox3;
        private System.Windows.Forms.Button btnReturnConfirm;
    }
}