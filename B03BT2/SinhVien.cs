using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B03BT2
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; } = DateTime.Now;
        public string GioiTinh { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }
    }
}
