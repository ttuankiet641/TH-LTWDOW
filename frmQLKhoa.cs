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
using baitap01.Models; // Namespace chứa các Entity và DbContext[cite: 69, 70]

namespace baitap01
{
    public partial class frmQLKhoa : Form
    {
        private int? idKhoaDangSua = null; // Lưu ID khoa đang chọn để sửa (null = thêm mới)

        public frmQLKhoa()
        {
            InitializeComponent();
            this.Load += frmQLKhoa_Load;
        }

        private void frmQLKhoa_Load(object sender, EventArgs e)
        {
            LamMoiForm();
            TaiDanhSachKhoa();
        }

        // 1. Tải danh sách Khoa lên DataGridView sử dụng EF Core
        private void TaiDanhSachKhoa()
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();
                var listKhoa = db.Khoas.ToList();
                dgvKhoa.DataSource = listKhoa;

                // Ẩn cột Id đi cho gọn giao diện
                if (dgvKhoa.Columns["Id"] != null) dgvKhoa.Columns["Id"].Visible = false;

                lblTongSoKhoa.Text = $"Tổng số Khoa: {listKhoa.Count}";
                lblTrangThai.Text = "Sẵn sàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối cơ sở dữ liệu:\n{ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTrangThai.Text = "Lỗi kết nối CSDL";
            }
        }

        // 2. Làm mới form về trạng thái ban đầu
        private void LamMoiForm()
        {
            txtTenKhoa.Clear();
            nudNamThanhLap.Value = 1996; // Giá trị mặc định năm thành lập
            nudTongSoGV.Value = 0;       // Giá trị mặc định số giảng viên
            idKhoaDangSua = null;
            txtTenKhoa.Enabled = true;
            dgvKhoa.ClearSelection();
        }

        // 3. Chức năng Thêm Khoa mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKhoa = txtTenKhoa.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập tên Khoa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
                return;
            }

            try
            {
                using var db = new QuanLySinhVienDbContext();
                // Kiểm tra trùng tên khoa
                if (db.Khoas.Any(k => k.TenKhoa.ToLower() == tenKhoa.ToLower()))
                {
                    MessageBox.Show("Tên khoa này đã tồn tại trong hệ thống!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var khoaMoi = new Khoa
                {
                    TenKhoa = tenKhoa,
                    NamThanhLap = (int)nudNamThanhLap.Value,
                    TongSoGiangVien = (int)nudTongSoGV.Value
                };

                db.Khoas.Add(khoaMoi);
                db.SaveChanges(); // Lưu xuống CSDL

                MessageBox.Show("Thêm khoa mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                TaiDanhSachKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Chức năng Sửa Khoa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idKhoaDangSua == null)
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenKhoa = txtTenKhoa.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Tên khoa không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new QuanLySinhVienDbContext();
                var khoa = db.Khoas.FirstOrDefault(k => k.Id == idKhoaDangSua);
                if (khoa != null)
                {
                    khoa.TenKhoa = tenKhoa;
                    khoa.NamThanhLap = (int)nudNamThanhLap.Value;
                    khoa.TongSoGiangVien = (int)nudTongSoGV.Value;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    TaiDanhSachKhoa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Chức năng Xóa Khoa (Có kiểm tra ràng buộc khóa ngoại với SinhVien)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idKhoaDangSua == null)
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    using var db = new QuanLySinhVienDbContext();

                    // Ràng buộc: Nếu khoa vẫn còn sinh viên thuộc về thì không cho phép xóa
                    bool coSinhVien = db.SinhViens.Any(sv => sv.KhoaId == idKhoaDangSua);
                    if (coSinhVien)
                    {
                        MessageBox.Show("Không thể xóa khoa này vì vẫn còn sinh viên đang theo học!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var khoa = db.Khoas.FirstOrDefault(k => k.Id == idKhoaDangSua);
                    if (khoa != null)
                    {
                        db.Khoas.Remove(khoa);
                        db.SaveChanges();
                        MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoiForm();
                        TaiDanhSachKhoa();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 6. Chức năng Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        // 7. Click chọn dòng trên DataGridView để đổ ngược dữ liệu lên các ô nhập
        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvKhoa.Rows[e.RowIndex].DataBoundItem is Khoa khoa)
            {
                txtTenKhoa.Text = khoa.TenKhoa;
                if (khoa.NamThanhLap.HasValue) nudNamThanhLap.Value = khoa.NamThanhLap.Value;
                if (khoa.TongSoGiangVien.HasValue) nudTongSoGV.Value = khoa.TongSoGiangVien.Value;
                idKhoaDangSua = khoa.Id;
            }
        }

        // Các sự kiện phụ (để trống nếu chưa dùng tới)
        private void txtTenKhoa_TextChanged(object sender, EventArgs e) { }
        private void nudNamThanhLap_ValueChanged(object sender, EventArgs e) { }
        private void nudTongSoGV_ValueChanged(object sender, EventArgs e) { }
    }
}