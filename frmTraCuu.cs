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
using baitap01.Models; // Namespace chứa các Entity và DbContext

namespace baitap01
{
    public partial class frmTraCuu : Form
    {
        public frmTraCuu()
        {
            InitializeComponent();
            this.Load += frmTraCuu_Load;
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            TaiComboBoxKhoa();
            ThucHienTimKiem(); // Hiển thị toàn bộ sinh viên khi mới mở form
        }

        // 1. Tải danh sách Khoa lên ComboBox lọc
        private void TaiComboBoxKhoa()
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();
                var dsKhoa = db.Khoas.ToList();

                // Thêm mục mặc định "Tất cả Khoa" vào đầu danh sách
                dsKhoa.Insert(0, new Khoa { Id = 0, TenKhoa = "-- Tất cả Khoa --" });

                cboLocKhoa.DataSource = dsKhoa;
                cboLocKhoa.DisplayMember = "TenKhoa";
                cboLocKhoa.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách khoa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Hàm thực hiện tìm kiếm và lọc dữ liệu sinh viên
        private void ThucHienTimKiem()
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();
                var query = db.SinhViens.Include(s => s.Khoa).AsQueryable();

                // Lọc theo từ khóa (Mã SV hoặc Họ tên)
                string tuKhoa = txtTuKhoa.Text.Trim();
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(s => s.MaSV.Contains(tuKhoa) || s.HoTen.Contains(tuKhoa));
                }

                // Lọc theo Khoa
                if (cboLocKhoa.SelectedValue is int khoaId && khoaId > 0)
                {
                    query = query.Where(s => s.KhoaId == khoaId);
                }

                // Lọc theo khoảng điểm TB (nếu người dùng nhập đầy đủ)
                if (double.TryParse(txtDiemTu.Text, out double diemTu) && double.TryParse(txtDiemDen.Text, out double diemDen))
                {
                    bool baoGomChuaCoDiem = chkChuaCoDiem.Checked;

                    if (baoGomChuaCoDiem)
                    {
                        query = query.Where(s => (s.DiemTB >= diemTu && s.DiemTB <= diemDen) || s.DiemTB == null);
                    }
                    else
                    {
                        query = query.Where(s => s.DiemTB >= diemTu && s.DiemTB <= diemDen);
                    }
                }

                var ketQua = query.ToList();
                dgvKetQua.DataSource = ketQua;

                // Ẩn các cột khóa hệ thống và đổi tên hiển thị cột Khoa
                if (dgvKetQua.Columns["Id"] != null) dgvKetQua.Columns["Id"].Visible = false;
                if (dgvKetQua.Columns["KhoaId"] != null) dgvKetQua.Columns["KhoaId"].Visible = false;
                if (dgvKetQua.Columns["Khoa"] != null) dgvKetQua.Columns["Khoa"].HeaderText = "Tên Khoa";

                lblThongBaoKetQua.Text = $"Tìm thấy: {ketQua.Count} sinh viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Các sự kiện xử lý tương tác giao diện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem(); // Tự động tìm kiếm realtime khi gõ chữ
        }

        private void cboLocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void txtDiemTu_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void txtDiemDen_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void chkChuaCoDiem_CheckedChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi click vào nội dung cell trên bảng kết quả (nếu cần)
        }

        private void lblThongBaoKetQua_Click(object sender, EventArgs e)
        {
            // Sự kiện phụ của nhãn thông báo
        }
    }
}