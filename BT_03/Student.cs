using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_03
{
    public class Student : Person
    {
        public double DiemTB { get; set; }

        public Student(string maSo, string hoTen, string khoa, string? soDienThoai, double diemTB)
            : base(maSo, hoTen, khoa, soDienThoai)
        {
            DiemTB = diemTB;
        }

        public override string ToString()
        {
            string sdtStr = string.IsNullOrEmpty(SoDienThoai) ? "Chưa cập nhật" : SoDienThoai;
            return $"Mã SV: {MaSo,-8} | Họ tên: {HoTen,-20} | Khoa: {Khoa,-15} | SĐT: {sdtStr,-15} | Điểm TB: {DiemTB:0.0}";
        }
    }
}
