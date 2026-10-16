namespace B03BT3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnButVe = new Button();
            btnDuongThang = new Button();
            btnHinhTron = new Button();
            btnCucTay = new Button();
            btnXoaTatCa = new Button();
            btnChuNhat = new Button();
            btnLuuAnh = new Button();
            trackBarDoDay = new TrackBar();
            btnChonMau = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblGiaTriDoDay = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarDoDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnButVe
            // 
            btnButVe.Location = new Point(18, 20);
            btnButVe.Name = "btnButVe";
            btnButVe.Size = new Size(98, 23);
            btnButVe.TabIndex = 0;
            btnButVe.Text = "bút vẽ";
            btnButVe.UseVisualStyleBackColor = true;
            btnButVe.Click += btnButVe_Click;
            // 
            // btnDuongThang
            // 
            btnDuongThang.Location = new Point(18, 49);
            btnDuongThang.Name = "btnDuongThang";
            btnDuongThang.Size = new Size(98, 23);
            btnDuongThang.TabIndex = 1;
            btnDuongThang.Text = "đường thẳng";
            btnDuongThang.UseVisualStyleBackColor = true;
            btnDuongThang.Click += btnDuongThang_Click;
            // 
            // btnHinhTron
            // 
            btnHinhTron.Location = new Point(18, 107);
            btnHinhTron.Name = "btnHinhTron";
            btnHinhTron.Size = new Size(98, 23);
            btnHinhTron.TabIndex = 3;
            btnHinhTron.Text = "hình tròn";
            btnHinhTron.UseVisualStyleBackColor = true;
            btnHinhTron.Click += btnHinhTron_Click;
            // 
            // btnCucTay
            // 
            btnCucTay.Location = new Point(18, 136);
            btnCucTay.Name = "btnCucTay";
            btnCucTay.Size = new Size(98, 23);
            btnCucTay.TabIndex = 4;
            btnCucTay.Text = "cục tẩy";
            btnCucTay.UseVisualStyleBackColor = true;
            btnCucTay.Click += btnCucTay_Click;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(18, 386);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(98, 23);
            btnXoaTatCa.TabIndex = 5;
            btnXoaTatCa.Text = "Xoá tất Cả";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // btnChuNhat
            // 
            btnChuNhat.Location = new Point(18, 78);
            btnChuNhat.Name = "btnChuNhat";
            btnChuNhat.Size = new Size(98, 23);
            btnChuNhat.TabIndex = 7;
            btnChuNhat.Text = "chữ nhật";
            btnChuNhat.UseVisualStyleBackColor = true;
            btnChuNhat.Click += btnChuNhat_Click;
            // 
            // btnLuuAnh
            // 
            btnLuuAnh.Location = new Point(18, 415);
            btnLuuAnh.Name = "btnLuuAnh";
            btnLuuAnh.Size = new Size(98, 23);
            btnLuuAnh.TabIndex = 8;
            btnLuuAnh.Text = "Lưu ảnh";
            btnLuuAnh.UseVisualStyleBackColor = true;
            btnLuuAnh.Click += btnLuuAnh_Click;
            // 
            // trackBarDoDay
            // 
            trackBarDoDay.Location = new Point(12, 284);
            trackBarDoDay.Name = "trackBarDoDay";
            trackBarDoDay.Size = new Size(104, 45);
            trackBarDoDay.TabIndex = 10;
            // 
            // btnChonMau
            // 
            btnChonMau.Location = new Point(68, 194);
            btnChonMau.Name = "btnChonMau";
            btnChonMau.Size = new Size(55, 23);
            btnChonMau.TabIndex = 11;
            btnChonMau.Text = "Chọn";
            btnChonMau.UseVisualStyleBackColor = true;
            btnChonMau.Click += btnChonMau_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 171);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 12;
            label1.Text = "Màu vẽ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 255);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 13;
            label2.Text = "Độ dày nét";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 34);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblGiaTriDoDay
            // 
            lblGiaTriDoDay.AutoSize = true;
            lblGiaTriDoDay.Location = new Point(16, 333);
            lblGiaTriDoDay.Name = "lblGiaTriDoDay";
            lblGiaTriDoDay.Size = new Size(47, 15);
            lblGiaTriDoDay.TabIndex = 16;
            lblGiaTriDoDay.Text = "Độ dày:";
            lblGiaTriDoDay.Click += lblGiaTriDoDay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGiaTriDoDay);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChonMau);
            Controls.Add(trackBarDoDay);
            Controls.Add(btnLuuAnh);
            Controls.Add(btnChuNhat);
            Controls.Add(btnXoaTatCa);
            Controls.Add(btnCucTay);
            Controls.Add(btnHinhTron);
            Controls.Add(btnDuongThang);
            Controls.Add(btnButVe);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)trackBarDoDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnButVe;
        private Button btnDuongThang;
        private Button btnHinhTron;
        private Button btnCucTay;
        private Button btnXoaTatCa;
        private Button btnChuNhat;
        private Button btnLuuAnh;
        private TrackBar trackBarDoDay;
        private Button btnChonMau;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblGiaTriDoDay;
    }
}
