using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap01
{
    public partial class frmThemKhoa : Form
    {
        // Property công khai để Form chính đọc giá trị sau khi người dùng bấm Lưu[cite: 68]
        public string? TenKhoaMoi { get; private set; }

        public frmThemKhoa()
        {
            InitializeComponent();
        }

        private void bttnLuu_Click(object sender, EventArgs e)
        {
            TenKhoaMoi = txtThemKhoa.Text.Trim();

            // Validate: Kiểm tra nếu để trống tên khoa[cite: 68]
            if (string.IsNullOrWhiteSpace(TenKhoaMoi))
            {
                MessageBox.Show("Vui lòng nhập tên Khoa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThemKhoa.Focus();
                return;
            }

            // Trả về kết quả OK và đóng form con[cite: 68]
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bttnHuy_Click(object sender, EventArgs e)
        {
            // Trả về kết quả Cancel và đóng form[cite: 68]
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtThemKhoa_TextChanged(object sender, EventArgs e)
        {
            // Sự kiện thay đổi text (để trống nếu không dùng)
        }
    }
}