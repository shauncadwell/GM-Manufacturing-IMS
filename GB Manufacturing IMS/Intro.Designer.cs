namespace GB_Manufacturing_IMS
{
    partial class Intro
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnOrderMaterials = new System.Windows.Forms.Button();
            this.btnOrderEquipment = new System.Windows.Forms.Button();
            this.pnltopBar = new System.Windows.Forms.Panel();
            this.btnSearchInv = new System.Windows.Forms.Button();
            this.pnltopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(195, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(613, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Management System";
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(944, 500);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(139, 40);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Exit Program";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnOrderMaterials
            // 
            this.btnOrderMaterials.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrderMaterials.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMaterials.Location = new System.Drawing.Point(47, 116);
            this.btnOrderMaterials.Name = "btnOrderMaterials";
            this.btnOrderMaterials.Size = new System.Drawing.Size(259, 120);
            this.btnOrderMaterials.TabIndex = 2;
            this.btnOrderMaterials.Text = "Order Materials";
            this.btnOrderMaterials.UseVisualStyleBackColor = false;
            this.btnOrderMaterials.Click += new System.EventHandler(this.btnOrderMaterials_Click);
            // 
            // btnOrderEquipment
            // 
            this.btnOrderEquipment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrderEquipment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderEquipment.Location = new System.Drawing.Point(312, 116);
            this.btnOrderEquipment.Name = "btnOrderEquipment";
            this.btnOrderEquipment.Size = new System.Drawing.Size(259, 120);
            this.btnOrderEquipment.TabIndex = 3;
            this.btnOrderEquipment.Text = "Order Equipment";
            this.btnOrderEquipment.UseVisualStyleBackColor = false;
            this.btnOrderEquipment.Click += new System.EventHandler(this.btnOrderEquipment_Click);
            // 
            // pnltopBar
            // 
            this.pnltopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnltopBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnltopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltopBar.Controls.Add(this.lblTitle);
            this.pnltopBar.Location = new System.Drawing.Point(-5, 0);
            this.pnltopBar.MinimumSize = new System.Drawing.Size(100, 0);
            this.pnltopBar.Name = "pnltopBar";
            this.pnltopBar.Size = new System.Drawing.Size(1101, 110);
            this.pnltopBar.TabIndex = 4;
            // 
            // btnSearchInv
            // 
            this.btnSearchInv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearchInv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInv.Location = new System.Drawing.Point(577, 116);
            this.btnSearchInv.Name = "btnSearchInv";
            this.btnSearchInv.Size = new System.Drawing.Size(259, 120);
            this.btnSearchInv.TabIndex = 5;
            this.btnSearchInv.Text = "Search Inventory";
            this.btnSearchInv.UseVisualStyleBackColor = false;
            this.btnSearchInv.Click += new System.EventHandler(this.btnSearchInv_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 552);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearchInv);
            this.Controls.Add(this.pnltopBar);
            this.Controls.Add(this.btnOrderEquipment);
            this.Controls.Add(this.btnOrderMaterials);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intro";
            this.ShowInTaskbar = false;
            this.Text = "Startup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnltopBar.ResumeLayout(false);
            this.pnltopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnOrderMaterials;
        private System.Windows.Forms.Button btnOrderEquipment;
        private System.Windows.Forms.Panel pnltopBar;
        private System.Windows.Forms.Button btnSearchInv;
    }
}