using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace B03BT2
{
    public partial class FrmDanhSachSinhVien : Form
    {
        private BindingList<SinhVien> danhSachSV = new BindingList<SinhVien>();

        public FrmDanhSachSinhVien()
        {
            InitializeComponent();


            dgvSinhVien.DataSource = danhSachSV;

            // Dữ liệu mẫu
            danhSachSV.Add(new SinhVien { MaSV = "SV001", HoTen = "Phan Văn Vinh", NgaySinh = new DateTime(2004, 5, 15), GioiTinh = "Nam", Khoa = "Công nghệ thông tin", DiemTB = 8.5 });
            danhSachSV.Add(new SinhVien { MaSV = "SV002", HoTen = "Trần Thị Mai", NgaySinh = new DateTime(2004, 8, 22), GioiTinh = "Nữ", Khoa = "Quản trị kinh doanh", DiemTB = 7.5 });
            danhSachSV.Add(new SinhVien { MaSV = "SV003", HoTen = "Lê Hoàng Long", NgaySinh = new DateTime(2003, 12, 10), GioiTinh = "Nam", Khoa = "Kế toán", DiemTB = 6.8 });

            // Cập nhật số lượng ban đầu khi mở form
            CapNhatTongSo();


        }
        // Hàm cập nhật chữ hiển thị tổng số sinh viên
        private void CapNhatTongSo()
        {
            lblTongSo.Text = $"Tổng số Sinh viên: {danhSachSV.Count}";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FrmChiTiet frm = new FrmChiTiet();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                danhSachSV.Add(frm.SinhVienData);
                CapNhatTongSo(); // Cập nhật lại tổng số sau khi thêm
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                var svDangChon = (SinhVien)dgvSinhVien.SelectedRows[0].DataBoundItem;
                FrmChiTiet frm = new FrmChiTiet(svDangChon);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvSinhVien.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                var svDangChon = (SinhVien)dgvSinhVien.SelectedRows[0].DataBoundItem;
                danhSachSV.Remove(svDangChon);
                CapNhatTongSo(); // Cập nhật lại tổng số sau khi xóa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}