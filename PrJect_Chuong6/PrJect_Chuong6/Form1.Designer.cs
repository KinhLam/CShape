namespace PrJect_Chuong6
{
    partial class Form1
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
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDen = new System.Windows.Forms.RadioButton();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDam = new System.Windows.Forms.RadioButton();
            this.radNghieng = new System.Windows.Forms.RadioButton();
            this.radGachChan = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChuoiDinhDang = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.Location = new System.Drawing.Point(214, 72);
            this.txtNhapChuoi.Multiline = true;
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(224, 20);
            this.txtNhapChuoi.TabIndex = 0;
            this.txtNhapChuoi.TextChanged += new System.EventHandler(this.txtNhapChuoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỊNH DẠNG CHUỖI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập chuỗi muốn định dạng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDen);
            this.groupBox1.Controls.Add(this.radDo);
            this.groupBox1.Controls.Add(this.radXanh);
            this.groupBox1.Location = new System.Drawing.Point(34, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu";
            // 
            // radDen
            // 
            this.radDen.Location = new System.Drawing.Point(7, 65);
            this.radDen.Name = "radDen";
            this.radDen.Size = new System.Drawing.Size(85, 17);
            this.radDen.TabIndex = 2;
            this.radDen.TabStop = true;
            this.radDen.Text = "Đen";
            this.radDen.UseVisualStyleBackColor = true;
            this.radDen.CheckedChanged += new System.EventHandler(this.radDen_CheckedChanged);
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.Location = new System.Drawing.Point(7, 43);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(39, 17);
            this.radDo.TabIndex = 1;
            this.radDo.TabStop = true;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            this.radDo.CheckedChanged += new System.EventHandler(this.radDo_CheckedChanged);
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.Location = new System.Drawing.Point(7, 20);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(50, 17);
            this.radXanh.TabIndex = 0;
            this.radXanh.TabStop = true;
            this.radXanh.Text = "Xanh";
            this.radXanh.UseVisualStyleBackColor = true;
            this.radXanh.CheckedChanged += new System.EventHandler(this.radXanh_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDam);
            this.groupBox2.Controls.Add(this.radNghieng);
            this.groupBox2.Controls.Add(this.radGachChan);
            this.groupBox2.Location = new System.Drawing.Point(34, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu hiển thị";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radDam
            // 
            this.radDam.AutoSize = true;
            this.radDam.Location = new System.Drawing.Point(7, 19);
            this.radDam.Name = "radDam";
            this.radDam.Size = new System.Drawing.Size(47, 17);
            this.radDam.TabIndex = 3;
            this.radDam.TabStop = true;
            this.radDam.Text = "Đậm";
            this.radDam.UseVisualStyleBackColor = true;
            this.radDam.CheckedChanged += new System.EventHandler(this.radDam_CheckedChanged);
            // 
            // radNghieng
            // 
            this.radNghieng.AutoSize = true;
            this.radNghieng.Location = new System.Drawing.Point(7, 42);
            this.radNghieng.Name = "radNghieng";
            this.radNghieng.Size = new System.Drawing.Size(65, 17);
            this.radNghieng.TabIndex = 4;
            this.radNghieng.TabStop = true;
            this.radNghieng.Text = "Nghiêng";
            this.radNghieng.UseVisualStyleBackColor = true;
            this.radNghieng.CheckedChanged += new System.EventHandler(this.radNghieng_CheckedChanged);
            // 
            // radGachChan
            // 
            this.radGachChan.AutoSize = true;
            this.radGachChan.Location = new System.Drawing.Point(7, 65);
            this.radGachChan.Name = "radGachChan";
            this.radGachChan.Size = new System.Drawing.Size(78, 17);
            this.radGachChan.TabIndex = 5;
            this.radGachChan.TabStop = true;
            this.radGachChan.Text = "Gạch chân";
            this.radGachChan.UseVisualStyleBackColor = true;
            this.radGachChan.CheckedChanged += new System.EventHandler(this.radGachChan_CheckedChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblChuoiDinhDang);
            this.groupBox3.Location = new System.Drawing.Point(234, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 230);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuỗi sau khi định dạng";
            // 
            // lblChuoiDinhDang
            // 
            this.lblChuoiDinhDang.AutoSize = true;
            this.lblChuoiDinhDang.Location = new System.Drawing.Point(15, 30);
            this.lblChuoiDinhDang.Name = "lblChuoiDinhDang";
            this.lblChuoiDinhDang.Size = new System.Drawing.Size(85, 13);
            this.lblChuoiDinhDang.TabIndex = 0;
            this.lblChuoiDinhDang.Text = "Chuỗi định dạng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(297, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapChuoi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblChuoiDinhDang;
        private System.Windows.Forms.RadioButton radDen;
        private System.Windows.Forms.RadioButton radDo;
        private System.Windows.Forms.RadioButton radXanh;
        private System.Windows.Forms.RadioButton radDam;
        private System.Windows.Forms.RadioButton radNghieng;
        private System.Windows.Forms.RadioButton radGachChan;
        private System.Windows.Forms.Button btnThoat;
    }
}

