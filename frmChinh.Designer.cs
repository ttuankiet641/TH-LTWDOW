namespace baitap01
{
    partial class frmChinh
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvSinhVien = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiemTB = new TextBox();
            cboKhoa = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblTrangThai = new Label();
            lblTongSo = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            btnThemKhoa = new Button();
            menuStrip1 = new MenuStrip();
            mnuTep = new ToolStripMenuItem();
            mnuDuLieu = new ToolStripMenuItem();
            mnuQuanLyKhoa = new ToolStripMenuItem();
            mnuTimKiem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.Location = new Point(339, 136);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(697, 402);
            dgvSinhVien.TabIndex = 40;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.CornflowerBlue;
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(267, 473);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(66, 26);
            btnLamMoi.TabIndex = 38;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Location = new Point(191, 473);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 26);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkOrange;
            btnSua.Location = new Point(106, 473);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 26);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Chartreuse;
            btnThem.Location = new Point(25, 473);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(109, 364);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(143, 23);
            txtDiemTB.TabIndex = 34;
            txtDiemTB.TextChanged += txtDiemTB_TextChanged;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(109, 408);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(145, 23);
            cboKhoa.TabIndex = 33;
            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(109, 275);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(193, 23);
            dtpNgaySinh.TabIndex = 32;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(109, 233);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(148, 23);
            txtHoTen.TabIndex = 31;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(109, 187);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(148, 23);
            txtMaSV.TabIndex = 30;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 372);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 28;
            label6.Text = "Điểm TB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 331);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 27;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 241);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 26;
            label4.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 416);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 25;
            label3.Text = "Khoa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 283);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 24;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 195);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 23;
            label1.Text = "Mã SV:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 136);
            label8.Name = "label8";
            label8.Size = new Size(164, 21);
            label8.TabIndex = 42;
            label8.Text = "Thông Tin Sinh Viên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(297, 47);
            label9.Name = "label9";
            label9.Size = new Size(343, 32);
            label9.TabIndex = 43;
            label9.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.ForeColor = Color.DarkGreen;
            lblTrangThai.Location = new Point(3, 577);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(13, 15);
            lblTrangThai.TabIndex = 44;
            lblTrangThai.Text = "0";
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.ForeColor = Color.Crimson;
            lblTongSo.Location = new Point(3, 552);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(13, 15);
            lblTongSo.TabIndex = 0;
            lblTongSo.Text = "1";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(113, 323);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 45;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(213, 323);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 46;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // btnThemKhoa
            // 
            btnThemKhoa.BackColor = Color.Coral;
            btnThemKhoa.Location = new Point(267, 407);
            btnThemKhoa.Name = "btnThemKhoa";
            btnThemKhoa.Size = new Size(41, 23);
            btnThemKhoa.TabIndex = 47;
            btnThemKhoa.Text = "+";
            btnThemKhoa.UseVisualStyleBackColor = false;
            btnThemKhoa.Click += btnThemKhoa_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep, mnuDuLieu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1065, 24);
            menuStrip1.TabIndex = 48;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTep
            // 
            mnuTep.Name = "mnuTep";
            mnuTep.Size = new Size(38, 20);
            mnuTep.Text = "Tệp";
            // 
            // mnuDuLieu
            // 
            mnuDuLieu.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyKhoa, mnuTimKiem, toolStripSeparator1, mnuThoat });
            mnuDuLieu.Name = "mnuDuLieu";
            mnuDuLieu.Size = new Size(56, 20);
            mnuDuLieu.Text = "Dữ liệu";
            // 
            // mnuQuanLyKhoa
            // 
            mnuQuanLyKhoa.Name = "mnuQuanLyKhoa";
            mnuQuanLyKhoa.ShortcutKeys = Keys.F1;
            mnuQuanLyKhoa.Size = new Size(163, 22);
            mnuQuanLyKhoa.Text = "Quản lý khoa";
            mnuQuanLyKhoa.Click += mnuQuanLyKhoa_Click;
            // 
            // mnuTimKiem
            // 
            mnuTimKiem.Name = "mnuTimKiem";
            mnuTimKiem.ShortcutKeys = Keys.Control | Keys.F;
            mnuTimKiem.Size = new Size(163, 22);
            mnuTimKiem.Text = "Tìm kiếm";
            mnuTimKiem.Click += mnuTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(160, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(163, 22);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // frmChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 601);
            Controls.Add(btnThemKhoa);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(lblTongSo);
            Controls.Add(lblTrangThai);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiemTB);
            Controls.Add(cboKhoa);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmChinh";
            Text = "Sinh Viên Hutech K23";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSinhVien;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiemTB;
        private ComboBox cboKhoa;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label lblTrangThai;
        private Label lblTongSo;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Button btnThemKhoa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTep;
        private ToolStripMenuItem mnuDuLieu;
        private ToolStripMenuItem mnuQuanLyKhoa;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
    }
}
