using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi02
{
    public partial class BT03 : Form
    {
        // Sử dụng BindingList để DataGridView tự động cập nhật khi danh sách thay đổi
        BindingList<SinhVien> danhSachSV = new BindingList<SinhVien>();

        public BT03()
        {
            InitializeComponent();





            danhSachSV.Add(new SinhVien { MaSV = "SV001", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2004, 5, 15), GioiTinh = "Nam", Khoa = "Công nghệ thông tin", DiemTB = 8.5 });
            danhSachSV.Add(new SinhVien { MaSV = "SV002", HoTen = "Trần Thị Mai", NgaySinh = new DateTime(2004, 8, 22), GioiTinh = "Nữ", Khoa = "Quản trị kinh doanh", DiemTB = 7.8 });
            danhSachSV.Add(new SinhVien { MaSV = "SV003", HoTen = "Lê Hoàng Long", NgaySinh = new DateTime(2003, 12, 10), GioiTinh = "Nam", Khoa = "Kế toán", DiemTB = 6.9 });

            // 1. Gắn nguồn dữ liệu cho DataGridView ngay khi mở form
            dgvSinhVien.DataSource = danhSachSV;

            // 2. Thêm dữ liệu cho ComboBox Giới tính
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            if (cboGioiTinh.Items.Count > 0)
                cboGioiTinh.SelectedIndex = 0; // Chọn sẵn dòng đầu tiên

            // 3. Thêm dữ liệu cho ComboBox Khoa (Bạn có thể đổi tên các khoa tùy theo yêu cầu bài tập)
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Quản trị kinh doanh");
            cboKhoa.Items.Add("Kế toán");
            if (cboKhoa.Items.Count > 0)
                cboKhoa.SelectedIndex = 0; // Chọn sẵn dòng đầu tiên
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtMaSV.Enabled = false; // Khóa không cho sửa Mã SV khi cập nhật
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value.ToString();
                cboKhoa.SelectedItem = row.Cells["Khoa"].Value.ToString();
                txtDiemTB.Text = row.Cells["DiemTB"].Value.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {// Validate dữ liệu trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng Mã SV
            string maSV = txtMaSV.Text.Trim();
            if (danhSachSV.Any(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng Điểm TB
            if (!double.TryParse(txtDiemTB.Text, out double diemTB) || diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Điểm trung bình phải là số hợp lệ từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tạo đối tượng sinh viên mới và thêm vào danh sách
            SinhVien sv = new SinhVien()
            {
                MaSV = maSV,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.SelectedItem.ToString(),
                Khoa = cboKhoa.SelectedItem.ToString(),
                DiemTB = diemTB
            };

            danhSachSV.Add(sv);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e); // Xóa trắng form sau khi thêm

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            SinhVien sv = danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));

            if (sv != null)
            {
                if (!double.TryParse(txtDiemTB.Text, out double diemTB) || diemTB < 0 || diemTB > 10)
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sv.HoTen = txtHoTen.Text.Trim();
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.GioiTinh = cboGioiTinh.SelectedItem.ToString();
                sv.Khoa = cboKhoa.SelectedItem.ToString();
                sv.DiemTB = diemTB;

                dgvSinhVien.Refresh(); // Làm tươi lại bảng hiển thị
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            SinhVien sv = danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));

            if (sv != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {sv.HoTen}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    danhSachSV.Remove(sv);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtMaSV.Enabled = true; // Mở lại khóa Mã SV để cho phép thêm mới
            txtHoTen.Clear();
            txtDiemTB.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            txtMaSV.Focus();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvSinhVien.DataSource = danhSachSV;
            }
            else
            {
                var ketQua = danhSachSV.Where(s => s.MaSV.ToLower().Contains(keyword) ||
                                                  s.HoTen.ToLower().Contains(keyword) ||
                                                  s.Khoa.ToLower().Contains(keyword)).ToList();
                dgvSinhVien.DataSource = new BindingList<SinhVien>(ketQua);
            }

        }
        
    }
}
