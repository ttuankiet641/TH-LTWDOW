namespace baitap01
{
    partial class frmTraCuu
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label9 = new Label();
            dgvKetQua = new DataGridView();
            label3 = new Label();
            txtTuKhoa = new TextBox();
            cboLocKhoa = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtDiemTu = new TextBox();
            label4 = new Label();
            txtDiemDen = new TextBox();
            chkChuaCoDiem = new CheckBox();
            btnTimKiem = new Button();
            lblThongBaoKetQua = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(230, 25);
            label9.Name = "label9";
            label9.Size = new Size(247, 32);
            label9.TabIndex = 44;
            label9.Text = "TRA CƯU SINH VIÊN";
            // 
            // dgvKetQua
            // 
            dgvKetQua.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.EnableHeadersVisualStyles = false;
            dgvKetQua.Location = new Point(12, 239);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.Size = new Size(722, 402);
            dgvKetQua.TabIndex = 45;
            dgvKetQua.CellContentClick += dgvKetQua_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 68);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 46;
            label3.Text = "Mã SV / Họ tên:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(125, 60);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(145, 23);
            txtTuKhoa.TabIndex = 47;
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
            // 
            // cboLocKhoa
            // 
            cboLocKhoa.FormattingEnabled = true;
            cboLocKhoa.Location = new Point(125, 94);
            cboLocKhoa.Name = "cboLocKhoa";
            cboLocKhoa.Size = new Size(145, 23);
            cboLocKhoa.TabIndex = 49;
            cboLocKhoa.SelectedIndexChanged += cboLocKhoa_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 97);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 48;
            label1.Text = "Khoa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 133);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 50;
            label2.Text = "Điểm TB từ:";
            // 
            // txtDiemTu
            // 
            txtDiemTu.Location = new Point(125, 131);
            txtDiemTu.Name = "txtDiemTu";
            txtDiemTu.Size = new Size(145, 23);
            txtDiemTu.TabIndex = 51;
            txtDiemTu.TextChanged += txtDiemTu_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 135);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 52;
            label4.Text = "đến";
            // 
            // txtDiemDen
            // 
            txtDiemDen.Location = new Point(350, 133);
            txtDiemDen.Name = "txtDiemDen";
            txtDiemDen.Size = new Size(137, 23);
            txtDiemDen.TabIndex = 53;
            txtDiemDen.TextChanged += txtDiemDen_TextChanged;
            // 
            // chkChuaCoDiem
            // 
            chkChuaCoDiem.AutoSize = true;
            chkChuaCoDiem.Location = new Point(28, 184);
            chkChuaCoDiem.Name = "chkChuaCoDiem";
            chkChuaCoDiem.Size = new Size(165, 19);
            chkChuaCoDiem.TabIndex = 54;
            chkChuaCoDiem.Text = "Bao gồm SV chưa có điểm";
            chkChuaCoDiem.UseVisualStyleBackColor = true;
            chkChuaCoDiem.CheckedChanged += chkChuaCoDiem_CheckedChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(221, 179);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 27);
            btnTimKiem.TabIndex = 55;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblThongBaoKetQua
            // 
            lblThongBaoKetQua.AutoSize = true;
            lblThongBaoKetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongBaoKetQua.Location = new Point(27, 214);
            lblThongBaoKetQua.Name = "lblThongBaoKetQua";
            lblThongBaoKetQua.Size = new Size(120, 15);
            lblThongBaoKetQua.TabIndex = 56;
            lblThongBaoKetQua.Text = "Tìm thấy: 0 sinh viên";
            lblThongBaoKetQua.Click += lblThongBaoKetQua_Click;
            // 
            // frmTraCuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 653);
            Controls.Add(lblThongBaoKetQua);
            Controls.Add(btnTimKiem);
            Controls.Add(chkChuaCoDiem);
            Controls.Add(txtDiemDen);
            Controls.Add(label4);
            Controls.Add(txtDiemTu);
            Controls.Add(label2);
            Controls.Add(cboLocKhoa);
            Controls.Add(label1);
            Controls.Add(txtTuKhoa);
            Controls.Add(label3);
            Controls.Add(dgvKetQua);
            Controls.Add(label9);
            Name = "frmTraCuu";
            Text = "Tra Cứu Sinh viên";
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dgvKetQua;
        private Label label3;
        private TextBox txtTuKhoa;
        private ComboBox cboLocKhoa;
        private Label label1;
        private Label label2;
        private TextBox txtDiemTu;
        private Label label4;
        private TextBox txtDiemDen;
        private CheckBox chkChuaCoDiem;
        private Button btnTimKiem;
        private Label lblThongBaoKetQua;
    }
}