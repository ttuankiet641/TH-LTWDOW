namespace baitap01
{
    partial class frmQLKhoa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvKhoa = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            txtTenKhoa = new TextBox();
            label4 = new Label();
            label1 = new Label();
            nudNamThanhLap = new NumericUpDown();
            label2 = new Label();
            nudTongSoGV = new NumericUpDown();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTongSoKhoa = new Label();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNamThanhLap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTongSoGV).BeginInit();
            SuspendLayout();
            // 
            // dgvKhoa
            // 
            dgvKhoa.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.EnableHeadersVisualStyles = false;
            dgvKhoa.Location = new Point(240, 124);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.Size = new Size(534, 357);
            dgvKhoa.TabIndex = 41;
            dgvKhoa.CellContentClick += dgvKhoa_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(340, 40);
            label9.Name = "label9";
            label9.Size = new Size(194, 32);
            label9.TabIndex = 44;
            label9.Text = "QUẢN LÝ KHOA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 124);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 45;
            label8.Text = "Thông Tin Khoa";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(23, 202);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(168, 23);
            txtTenKhoa.TabIndex = 47;
            txtTenKhoa.TextChanged += txtTenKhoa_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 174);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 46;
            label4.Text = "Tên Khoa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 247);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 48;
            label1.Text = "Năm thành lập:";
            // 
            // nudNamThanhLap
            // 
            nudNamThanhLap.Location = new Point(23, 274);
            nudNamThanhLap.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            nudNamThanhLap.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNamThanhLap.Name = "nudNamThanhLap";
            nudNamThanhLap.Size = new Size(120, 23);
            nudNamThanhLap.TabIndex = 49;
            nudNamThanhLap.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNamThanhLap.ValueChanged += nudNamThanhLap_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 321);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 50;
            label2.Text = "Tổng số Giảng viên:";
            // 
            // nudTongSoGV
            // 
            nudTongSoGV.Location = new Point(23, 356);
            nudTongSoGV.Name = "nudTongSoGV";
            nudTongSoGV.Size = new Size(120, 23);
            nudTongSoGV.TabIndex = 51;
            nudTongSoGV.ValueChanged += nudTongSoGV_ValueChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.CornflowerBlue;
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(136, 455);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(79, 26);
            btnLamMoi.TabIndex = 55;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Location = new Point(23, 455);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 26);
            btnXoa.TabIndex = 54;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkOrange;
            btnSua.Location = new Point(136, 414);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 26);
            btnSua.TabIndex = 53;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Chartreuse;
            btnThem.Location = new Point(23, 414);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTongSoKhoa
            // 
            lblTongSoKhoa.AutoSize = true;
            lblTongSoKhoa.ForeColor = Color.Red;
            lblTongSoKhoa.Location = new Point(12, 512);
            lblTongSoKhoa.Name = "lblTongSoKhoa";
            lblTongSoKhoa.Size = new Size(79, 15);
            lblTongSoKhoa.TabIndex = 56;
            lblTongSoKhoa.Text = "tổng số khoa:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.ForeColor = Color.ForestGreen;
            lblTrangThai.Location = new Point(12, 535);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(54, 15);
            lblTrangThai.TabIndex = 57;
            lblTrangThai.Text = "Sẵn sàng";
            // 
            // frmQLKhoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 559);
            Controls.Add(lblTrangThai);
            Controls.Add(lblTongSoKhoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(nudTongSoGV);
            Controls.Add(label2);
            Controls.Add(nudNamThanhLap);
            Controls.Add(label1);
            Controls.Add(txtTenKhoa);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dgvKhoa);
            Name = "frmQLKhoa";
            Text = "Quản Lý Khoa";
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNamThanhLap).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTongSoGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhoa;
        private Label label9;
        private Label label8;
        private TextBox txtTenKhoa;
        private Label label4;
        private Label label1;
        private NumericUpDown nudNamThanhLap;
        private Label label2;
        private NumericUpDown nudTongSoGV;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblTongSoKhoa;
        private Label lblTrangThai;
    }
}