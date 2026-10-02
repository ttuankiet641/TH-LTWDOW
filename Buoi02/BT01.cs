namespace Buoi02
{
    public partial class BT01 : Form
    {
        public BT01()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                "Vui lòng nhập họ tên!",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            // 2. Lấy giới tính từ RadioButton
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            // 3. Tính tuổi từ DateTimePicker
            int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            // 4. Gom các sở thích đã chọn từ CheckBox
            List<string> soThich = new List<string>();
            if (chkDocSach.Checked) soThich.Add("Đọc sách");
            if (chkTheThao.Checked) soThich.Add("Thể thao");
            if (chkAmNhac.Checked) soThich.Add("Âm nhạc");
            string chuoiSoThich = soThich.Count > 0
            ? string.Join(", ", soThich)
            : "chưa chọn sở thích nào";
            // 5. Hiển thị kết quả tổng hợp
            lblKetQua.Text = $"Xin chào {gioiTinh} {txtHoTen.Text}, {tuoi} tuổi.\n" + $"Sở thích: {chuoiSoThich}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định khi form vừa mở
            rdoNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            lblKetQua.Text = "";
        }
    }
}