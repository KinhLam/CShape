namespace PrJect_Chuong6
{
    partial class frm_FlowLayoutPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FlowLayoutPanel));
            this.myFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myFlowLayoutPanel
            // 
            this.myFlowLayoutPanel.AutoScroll = true;
            this.myFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myFlowLayoutPanel.Location = new System.Drawing.Point(48, 34);
            this.myFlowLayoutPanel.Name = "myFlowLayoutPanel";
            this.myFlowLayoutPanel.Size = new System.Drawing.Size(339, 134);
            this.myFlowLayoutPanel.TabIndex = 1;
            this.myFlowLayoutPanel.WrapContents = false;
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(48, 186);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(339, 266);
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "z3458353873409_6d71bb4e33d8d78e9351a75c347d45d6.jpg");
            this.myImageList.Images.SetKeyName(1, "z3458353878443_f4a526965dc2d88b5f19e55e27393430.jpg");
            this.myImageList.Images.SetKeyName(2, "z3458353886754_f477a33d6621ca248c25b129ad137fb9.jpg");
            this.myImageList.Images.SetKeyName(3, "z3458353891661_5c970489b961f788383534b60f587d6c.jpg");
            this.myImageList.Images.SetKeyName(4, "z3458353899748_3e89e8adf82f610d616ab33e1b57fd09.jpg");
            // 
            // frm_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 493);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.myFlowLayoutPanel);
            this.Name = "frm_Panel";
            this.Text = "FlowLayoutPanel";
            this.Load += new System.EventHandler(this.frm_Panel_Load);
            this.Click += new System.EventHandler(this.frm_Panel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.ImageList myImageList;
    }
}