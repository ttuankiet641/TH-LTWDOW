using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    internal class SinhVien
    {
        [DisplayName("Mã SV")]
        public string MaSV { get; set; } = "";

        [DisplayName("Họ tên")]
        public string HoTen { get; set; } = "";

        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; } = "";

        [DisplayName("Khoa")]
        public string Khoa { get; set; } = "";

        [DisplayName("Điểm TB")]
        public double? DiemTB { get; set; } // null = chưa có điểm
    }
}
