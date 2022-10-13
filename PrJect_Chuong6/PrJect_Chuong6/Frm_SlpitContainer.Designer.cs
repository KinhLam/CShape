namespace PrJect_Chuong6
{
    partial class Frm_SlpitContainer
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listLinkWebsite = new System.Windows.Forms.ListView();
            this.myWebsite = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(149, 71);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(230, 71);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(311, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thêm đường dẫn";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(149, 22);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(237, 20);
            this.txtLink.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(42, 120);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listLinkWebsite);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.myWebsite);
            this.splitContainer1.Size = new System.Drawing.Size(344, 199);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(311, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listLinkWebsite
            // 
            this.listLinkWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLinkWebsite.HideSelection = false;
            this.listLinkWebsite.Location = new System.Drawing.Point(0, 0);
            this.listLinkWebsite.Name = "listLinkWebsite";
            this.listLinkWebsite.Size = new System.Drawing.Size(112, 197);
            this.listLinkWebsite.TabIndex = 0;
            this.listLinkWebsite.UseCompatibleStateImageBehavior = false;
            this.listLinkWebsite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listLinkWebsite_MouseClick);
            // 
            // myWebsite
            // 
            this.myWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myWebsite.Location = new System.Drawing.Point(0, 0);
            this.myWebsite.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWebsite.Name = "myWebsite";
            this.myWebsite.Size = new System.Drawing.Size(224, 197);
            this.myWebsite.TabIndex = 0;
            // 
            // Frm_SlpitContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Name = "Frm_SlpitContainer";
            this.Text = "Frm_SlpitContainer";
            this.Load += new System.EventHandler(this.Frm_SlpitContainer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listLinkWebsite;
        private System.Windows.Forms.WebBrowser myWebsite;
    }
}