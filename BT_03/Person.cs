using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_03
{
    public class Person
    {
        public string MaSo { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string Khoa { get; set; } = "";
        public string? SoDienThoai { get; set; }

        public Person(string maSo, string hoTen, string khoa, string? soDienThoai)
        {
            MaSo = maSo;
            HoTen = hoTen;
            Khoa = khoa;
            SoDienThoai = soDienThoai;
        }
    }
}
