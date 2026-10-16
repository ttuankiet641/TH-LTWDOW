using System;
using System.Windows.Forms;

namespace B03BT2
{
    public partial class FrmChiTiet : Form
    {
        public SinhVien SinhVienData { get; set; }

        public FrmChiTiet()
        {
            InitializeComponent();
            SinhVienData = new SinhVien();

            radNam.Checked = true;
            cboKhoa.Items.AddRange(new string[] { "Công nghệ thông tin", "Quản trị kinh doanh", "Kế toán", "Ngôn ngữ Anh" });
            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }
        }

        public FrmChiTiet(SinhVien sv) : this()
        {
            SinhVienData = sv;

            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;

            if (sv.GioiTinh == "Nữ")
            {
                radNu.Checked = true;
            }
            else
            {
                radNam.Checked = true;
            }

            cboKhoa.Text = sv.Khoa;
            txtDiemTB.Text = sv.DiemTB.ToString();
            txtMaSV.Enabled = false; // Khóa mã sinh viên khi ở chế độ sửa
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVienData.MaSV = txtMaSV.Text.Trim();
            SinhVienData.HoTen = txtHoTen.Text.Trim();
            SinhVienData.NgaySinh = dtpNgaySinh.Value;
            SinhVienData.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            SinhVienData.Khoa = cboKhoa.Text;

            if (double.TryParse(txtDiemTB.Text, out double diem))
            {
                SinhVienData.DiemTB = diem;
            }
            else
            {
                SinhVienData.DiemTB = 0;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}