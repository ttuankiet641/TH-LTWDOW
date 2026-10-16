using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace B03BT3
{
    public partial class Form1 : Form
    {
        // Quản lý các công cụ vẽ bằng Enum
        private enum CongCuVe { ButVe, DuongThang, HinhChuNhat, HinhTron, CucTay }
        private CongCuVe congCuHienTai = CongCuVe.ButVe;

        private bool đangVẽ = false;
        private Point điểmBắtĐầu;
        private Point điểmHiệnTại;

        private Bitmap canvasBitmap; // Vùng đệm lưu lại toàn bộ bức tranh
        private Color mauHienTai = Color.Black;
        private int doDayNett = 3;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Chống giật màn hình khi vẽ

            // Đăng ký sự kiện cuộn cho thanh TrackBar
            trackBarDoDay.Minimum = 1;
            trackBarDoDay.Maximum = 20;
            trackBarDoDay.Value = doDayNett;
            trackBarDoDay.Scroll += trackBar1_Scroll;

            // Đăng ký sự kiện Load cho Form
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo kích thước vùng đệm canvas màu trắng
            canvasBitmap = new Bitmap(Math.Max(1, this.ClientSize.Width), Math.Max(1, this.ClientSize.Height));
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White);
            }

            // Hiển thị màu và độ dày mặc định lên giao diện
            pictureBox1.BackColor = mauHienTai;
            trackBarDoDay.Text = $"Độ dày: {doDayNett}";
        }

        // 1. Sự kiện MouseDown: Ghi nhận điểm bắt đầu vẽ
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                đangVẽ = true;
                điểmBắtĐầu = e.Location;
                điểmHiệnTại = e.Location;
            }
        }

        // 2. Sự kiện MouseMove: Xử lý vẽ tự do hoặc cập nhật điểm xem trước hình khối
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (đangVẽ)
            {
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    if (congCuHienTai == CongCuVe.ButVe || congCuHienTai == CongCuVe.CucTay)
                    {
                        Color colorToUse = (congCuHienTai == CongCuVe.CucTay) ? Color.White : mauHienTai;
                        int sizeToUse = (congCuHienTai == CongCuVe.CucTay) ? doDayNett * 3 : doDayNett;

                        using (Pen pen = new Pen(colorToUse, sizeToUse))
                        {
                            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                            g.DrawLine(pen, điểmBắtĐầu, e.Location);
                        }
                        điểmBắtĐầu = e.Location;
                    }
                }

                điểmHiệnTại = e.Location;
                this.Invalidate(); // Yêu cầu vẽ lại giao diện
            }
        }

        // 3. Sự kiện MouseUp: Kết thúc nét vẽ hoặc vẽ chính thức hình khối lên canvas
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (đangVẽ && e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    using (Pen pen = new Pen(mauHienTai, doDayNett))
                    {
                        Rectangle rect = GetRectangle(điểmBắtĐầu, e.Location);

                        switch (congCuHienTai)
                        {
                            case CongCuVe.DuongThang:
                                g.DrawLine(pen, điểmBắtĐầu, e.Location);
                                break;
                            case CongCuVe.HinhChuNhat:
                                g.DrawRectangle(pen, rect);
                                break;
                            case CongCuVe.HinhTron:
                                g.DrawEllipse(pen, rect);
                                break;
                        }
                    }
                }

                đangVẽ = false;
                this.Invalidate();
            }
        }

        // Hàm tính toán tọa độ hình chữ nhật chuẩn từ 2 điểm
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

        // 4. Vẽ lại giao diện kèm theo khung xem trước (Preview) hình học
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (canvasBitmap != null)
            {
                e.Graphics.DrawImage(canvasBitmap, 0, 0);

                if (đangVẽ && (congCuHienTai == CongCuVe.DuongThang || congCuHienTai == CongCuVe.HinhChuNhat || congCuHienTai == CongCuVe.HinhTron))
                {
                    using (Pen previewPen = new Pen(mauHienTai, doDayNett))
                    {
                        previewPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        Rectangle rect = GetRectangle(điểmBắtĐầu, điểmHiệnTại);

                        if (congCuHienTai == CongCuVe.DuongThang)
                        {
                            e.Graphics.DrawLine(previewPen, điểmBắtĐầu, điểmHiệnTại);
                        }
                        else if (congCuHienTai == CongCuVe.HinhChuNhat)
                        {
                            e.Graphics.DrawRectangle(previewPen, rect);
                        }
                        else if (congCuHienTai == CongCuVe.HinhTron)
                        {
                            e.Graphics.DrawEllipse(previewPen, rect);
                        }
                    }
                }
            }
        }

        // --- XỬ LÝ SỰ KIỆN CÁC NÚT BẤM & CONTROL ---

        private void btnButVe_Click(object sender, EventArgs e)
        {
            congCuHienTai = CongCuVe.ButVe;
        }

        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            congCuHienTai = CongCuVe.DuongThang;
        }

        private void btnChuNhat_Click(object sender, EventArgs e)
        {
            congCuHienTai = CongCuVe.HinhChuNhat;
        }

        private void btnHinhTron_Click(object sender, EventArgs e)
        {
            congCuHienTai = CongCuVe.HinhTron;
        }

        private void btnCucTay_Click(object sender, EventArgs e)
        {
            congCuHienTai = CongCuVe.CucTay;
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    mauHienTai = cd.Color;
                    pictureBox1.BackColor = mauHienTai; // Cập nhật màu lên ô hiển thị
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            doDayNett = trackBarDoDay.Value; // Lấy giá trị trực tiếp từ TrackBar
            lblGiaTriDoDay.Text = $"Độ dày: {doDayNett}"; // Cập nhật ra Label hiển thị
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ bức vẽ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.Clear(Color.White);
                }
                this.Invalidate();
            }
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    canvasBitmap.Save(sfd.FileName);
                    MessageBox.Show("Lưu bức vẽ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblGiaTriDoDay_Click(object sender, EventArgs e)
        {

        }
    }
}