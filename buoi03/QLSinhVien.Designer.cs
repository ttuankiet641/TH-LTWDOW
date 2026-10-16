namespace buoi03
{
    partial class QLSinhVien
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
            cboGioiTinh = new ComboBox();
            dgvSinhVien = new DataGridView();
            txtTimKiem = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiemTB = new TextBox();
            cboKhoa = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(421, 78);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(143, 23);
            cboGioiTinh.TabIndex = 41;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(36, 297);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(528, 265);
            dgvSinhVien.TabIndex = 40;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(120, 256);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(193, 23);
            txtTimKiem.TabIndex = 39;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(255, 128, 255);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(393, 178);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(66, 26);
            btnLamMoi.TabIndex = 38;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Location = new Point(278, 178);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 26);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Location = new Point(153, 178);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 26);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 255, 128);
            btnThem.Location = new Point(36, 178);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(421, 121);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(143, 23);
            txtDiemTB.TabIndex = 34;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(120, 126);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(193, 23);
            cboKhoa.TabIndex = 33;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(120, 70);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(193, 23);
            dtpNgaySinh.TabIndex = 32;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(370, 22);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(132, 23);
            txtHoTen.TabIndex = 31;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(120, 17);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(148, 23);
            txtMaSV.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 257);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 29;
            label7.Text = "Tìm kiếm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 124);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 28;
            label6.Text = "Điểm TB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 76);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 27;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 25);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 26;
            label4.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 129);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 25;
            label3.Text = "Khoa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 78);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 24;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 23;
            label1.Text = "Mã SV:";
            // 
            // QLSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 597);
            Controls.Add(cboGioiTinh);
            Controls.Add(dgvSinhVien);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiemTB);
            Controls.Add(cboKhoa);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QLSinhVien";
            Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboGioiTinh;
        private DataGridView dgvSinhVien;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiemTB;
        private ComboBox cboKhoa;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}