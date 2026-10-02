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
    public partial class BT02 : Form
    {
        public BT02()
        {
            InitializeComponent();

        }
        private bool LayGiaTri(out double so1, out double so2)
        {
            so1 = 0;
            so2 = 0;

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtSo1.Text) || string.IsNullOrWhiteSpace(txtSo2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ cả hai số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số hợp lệ
            if (!double.TryParse(txtSo1.Text, out so1) || !double.TryParse(txtSo2.Text, out so2))
            {
                MessageBox.Show("Giá trị nhập vào phải là định dạng số hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            if (!LayGiaTri(out double so1, out double so2))
            {
                return;
            }

            Button btn = sender as Button;
            if (btn == null) return;

            double ketQua = 0;
            string phepToan = "";

            // Xác định phép tính dựa trên nút được bấm
            if (btn == btnCong)
            {
                ketQua = so1 + so2;
                phepToan = "+";
            }
            else if (btn == btnTru)
            {
                ketQua = so1 - so2;
                phepToan = "-";
            }
            else if (btn == btnNhan)
            {
                ketQua = so1 * so2;
                phepToan = "×";
            }
            else if (btn == btnChia)
            {
                // Xử lý ngoại lệ chia cho 0
                if (so2 == 0)
                {
                    MessageBox.Show("Không thể thực hiện phép chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ketQua = so1 / so2;
                phepToan = "÷";
            }

            // Hiển thị kết quả lên giao diện
            lblKetQua.Text = $"Kết quả: {so1} {phepToan} {so2} = {ketQua}";

            // Thêm lịch sử vào danh sách (đưa mục mới nhất lên đầu danh sách)
            string itemLichSu = $"{DateTime.Now:HH:mm:ss} - {so1} {phepToan} {so2} = {ketQua}";
            lstLichSu.Items.Insert(0, itemLichSu);
        }

        private void btnXoaLichSu_Click(object sender, EventArgs e)
        {
            if (lstLichSu.Items.Count == 0)
            {
                MessageBox.Show("Lịch sử đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ lịch sử tính toán không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lstLichSu.Items.Clear();
                lblKetQua.Text = "Kết quả: 0";
            }
        }
    }
}
