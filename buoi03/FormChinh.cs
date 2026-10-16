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
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
            this.MdiChildActivate += Formchinh_MdiChildActivate;

        }
        private void Formchinh_MdiChildActivate(object? sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.Text = $"Hệ Thống Quản Lý — HUTECH | Đang xem: {this.ActiveMdiChild.Text}";
            }
            else
            {
                this.Text = "Hệ Thống Quản Lý — HUTECH";
            }
        }

        // Hàm chung chống mở trùng form con
        private void MoFormKhongTrung<T>() where T : Form, new()
        {
            foreach (Form formCon in this.MdiChildren)
            {
                if (formCon is T)
                {
                    formCon.Activate(); // Nếu đã mở thì focus nổi lên trên
                    return;
                }
            }
            T formMoi = new T();
            formMoi.MdiParent = this; // Đặt form cha là form chính
            formMoi.Show();
        }
        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormKhongTrung<QLSinhVien>();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormKhongTrung<QLKhoaHoc>();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool KiemTraCoCuaSoDangMo()
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show("Chưa có cửa sổ nào để sắp xếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void sắpXếpTầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.Cascade); // Sắp xếp tầng
        }

        private void sắpXếpTầngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.TileHorizontal); // Sắp xếp ngang
        }

        private void sắpXếpTầngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.TileVertical); // Sắp xếp dọc

        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show("Không có cửa sổ nào đang mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var ketQua = MessageBox.Show($"Bạn có chắc muốn đóng tất cả {this.MdiChildren.Length} cửa sổ đang mở?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                foreach (Form formCon in this.MdiChildren.ToList())
                {
                    formCon.Close(); // Đóng từng form con
                }
            }
        }
    }
}