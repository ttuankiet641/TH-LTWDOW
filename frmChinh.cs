using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using baitap01.Models; // Namespace chứa các Entity (SinhVien, Khoa, DbContext)[cite: 69, 70]

namespace baitap01
{
    public partial class frmChinh : Form
    {
        private int? idDangSua = null; // Lưu ID sinh viên đang được chọn để sửa (null = thêm mới)[cite: 78]

        public frmChinh()
        {
            InitializeComponent();
            this.Load += frmChinh_Load;
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            LayDanhSachKhoa();
            LamMoiForm();
            LayDanhSachSinhVien();
        }

        // 1. Tải danh sách Khoa lên ComboBox
        private void LayDanhSachKhoa()
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();
                cboKhoa.DataSource = db.Khoas.ToList();
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách khoa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Tải danh sách Sinh viên lên DataGridView sử dụng EF Core[cite: 67, 69]
        private void LayDanhSachSinhVien()
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();
                var listStudent = db.SinhViens.Include(sv => sv.Khoa).ToList();

                dgvSinhVien.DataSource = listStudent;

                // Ẩn các cột khóa ngoại không cần thiết hiển thị trực tiếp bằng ID
                if (dgvSinhVien.Columns["Id"] != null) dgvSinhVien.Columns["Id"].Visible = false;
                if (dgvSinhVien.Columns["KhoaId"] != null) dgvSinhVien.Columns["KhoaId"].Visible = false;
                if (dgvSinhVien.Columns["Khoa"] != null) dgvSinhVien.Columns["Khoa"].HeaderText = "Tên Khoa";

                lblTongSo.Text = $"Tổng số sinh viên: {db.SinhViens.Count()}";
                lblTrangThai.Text = "Sẵn sàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối cơ sở dữ liệu:\n{ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTrangThai.Text = "Lỗi kết nối CSDL";
            }
        }

        // 3. Làm mới form về trạng thái ban đầu
        private void LamMoiForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            rdoNam.Checked = true;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            txtMaSV.Enabled = true;
            idDangSua = null;
            dgvSinhVien.ClearSelection();
        }

        // 4. Chức năng Thêm sinh viên xuống CSDL[cite: 70]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            double? diemTB = null;

            if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                if (!double.TryParse(txtDiemTB.Text, out double diem) || diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm TB phải là số hợp lệ từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                diemTB = diem;
            }

            try
            {
                using var db = new QuanLySinhVienDbContext();
                // Kiểm tra trùng Mã SV bằng truy vấn trong database[cite: 70]
                if (db.SinhViens.Any(sv => sv.MaSV == maSV))
                {
                    MessageBox.Show($"Mã SV '{maSV}' đã tồn tại!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var svMoi = new SinhVien
                {
                    MaSV = maSV,
                    HoTen = hoTen,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                    KhoaId = (int)cboKhoa.SelectedValue,
                    DiemTB = diemTB
                };

                db.SinhViens.Add(svMoi);
                db.SaveChanges(); // Lưu thay đổi xuống cơ sở dữ liệu[cite: 70]

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                LayDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lưu thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Chức năng Sửa sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idDangSua == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double? diemTB = null;
            if (!string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                if (!double.TryParse(txtDiemTB.Text, out double diem) || diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm TB phải là số hợp lệ từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                diemTB = diem;
            }

            try
            {
                using var db = new QuanLySinhVienDbContext();
                var sv = db.SinhViens.FirstOrDefault(s => s.Id == idDangSua);
                if (sv != null)
                {
                    sv.HoTen = hoTen;
                    sv.NgaySinh = dtpNgaySinh.Value;
                    sv.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                    sv.KhoaId = (int)cboKhoa.SelectedValue;
                    sv.DiemTB = diemTB;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    LayDanhSachSinhVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Chức năng Xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idDangSua == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    using var db = new QuanLySinhVienDbContext();
                    var sv = db.SinhViens.FirstOrDefault(s => s.Id == idDangSua);
                    if (sv != null)
                    {
                        db.SinhViens.Remove(sv);
                        db.SaveChanges();
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoiForm();
                        LayDanhSachSinhVien();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 7. Chức năng Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        // 8. Chức năng Mở form Thêm Khoa mới (khi bấm nút dấu +)
        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            frmThemKhoa formThemKhoa = new frmThemKhoa();

            // Mở form dạng ShowDialog để chờ người dùng thao tác
            if (formThemKhoa.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using var db = new QuanLySinhVienDbContext();
                    string tenKhoaMoi = formThemKhoa.TenKhoaMoi!;

                    // Kiểm tra xem tên khoa đã tồn tại trong CSDL chưa
                    if (db.Khoas.Any(k => k.TenKhoa.ToLower() == tenKhoaMoi.ToLower()))
                    {
                        MessageBox.Show("Tên khoa đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thêm khoa mới vào database
                    db.Khoas.Add(new Khoa { TenKhoa = tenKhoaMoi });
                    db.SaveChanges(); // Lưu thay đổi

                    // Cập nhật lại danh sách trên ComboBox của Form chính
                    LayDanhSachKhoa();

                    MessageBox.Show("Thêm khoa mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lưu thất bại:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 9. Click vào dòng trên DataGridView để đổ ngược dữ liệu lên các ô nhập
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
            {
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                dtpNgaySinh.Value = sv.NgaySinh;
                rdoNam.Checked = sv.GioiTinh == "Nam";
                rdoNu.Checked = sv.GioiTinh == "Nữ";
                cboKhoa.SelectedValue = sv.KhoaId;
                txtDiemTB.Text = sv.DiemTB?.ToString() ?? "";
                idDangSua = sv.Id;
                txtMaSV.Enabled = false; // Khóa mã sinh viên không cho sửa khi ở chế độ cập nhật
            }
        }

        // Các sự kiện TextChanged/SelectedIndexChanged (để trống nếu chưa dùng tới)
        private void txtMaSV_TextChanged(object sender, EventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void txtDiemTB_TextChanged(object sender, EventArgs e) { }
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e) { }

        // 1. Sự kiện mở giao diện Quản lý Khoa khi bấm menu hoặc nhấn F1
        private void mnuQuanLyKhoa_Click(object sender, EventArgs e)
        {
            // Giả sử bạn tạo một Form quản lý khoa tên là frmQuanLyKhoa
            // Nếu chưa có form này, bạn có thể tạo mới một Windows Form tên frmQuanLyKhoa
            frmQLKhoa frmKhoa = new frmQLKhoa();
            frmKhoa.ShowDialog();

            // Sau khi đóng form quản lý khoa, cập nhật lại ComboBox Khoa ở form chính
            LayDanhSachKhoa();
        }
        // 2. Sự kiện mở giao diện Tìm kiếm/Tra cứu khi bấm menu hoặc nhấn Ctrl+F
        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            frmTraCuu frmTimKiem = new frmTraCuu();
            frmTimKiem.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            var xacNhan = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}