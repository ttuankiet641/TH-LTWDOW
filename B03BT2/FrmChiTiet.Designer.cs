namespace B03BT2
{
    partial class FrmChiTiet
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtDiemTB = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpNgaySinh = new DateTimePicker();
            radNam = new RadioButton();
            radNu = new RadioButton();
            cboKhoa = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ Và Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 257);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Điểm TB:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(115, 26);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(162, 23);
            txtMaSV.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(115, 80);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(162, 23);
            txtHoTen.TabIndex = 4;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(101, 249);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(162, 23);
            txtDiemTB.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(128, 255, 128);
            btnLuu.Location = new Point(101, 303);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 255, 128);
            btnHuy.Location = new Point(188, 303);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Huỷ Bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 128);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 172);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 212);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "Khoa:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(114, 127);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 11;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(134, 168);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 12;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(225, 168);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 13;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(101, 209);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(121, 23);
            cboKhoa.TabIndex = 14;
            // 
            // FrmChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 352);
            Controls.Add(cboKhoa);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDiemTB);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmChiTiet";
            Text = "FrmChiTiet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtDiemTB;
        private Button btnLuu;
        private Button btnHuy;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNgaySinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private ComboBox cboKhoa;
    }
}