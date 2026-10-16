using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi03
{
    public partial class QLKhoaHoc : Form
    {
        public QLKhoaHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã nhập đủ Mã khóa học và Tên khóa học chưa
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã khóa học và Tên khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gom nhóm thông tin khóa học thành một chuỗi hiển thị
            string info = $"Mã KH: {txtMaKH.Text} - Tên KH: {txtTenKH.Text} - Số tín chỉ: {nudSoTinChi.Value}";

            // 3. Thêm vào ListBox (lstKhoaHoc)
            lstKhoaHoc.Items.Add(info);

            // 4. Xóa trắng các ô nhập liệu sau khi thêm thành công để chuẩn bị nhập tiếp
            txtMaKH.Clear();
            txtTenKH.Clear();
            nudSoTinChi.Value = 0;
            txtMaKH.Focus(); // Đưa con trỏ chuột về ô Mã khóa học
        }
    }
}
