using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_02
{
    public class Student
    {
        public string Maso { get; set; }
        public string HoTen { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }
        public string? SoDienThoai { get; set; } // Nullable nếu không nhập

        public Student(string maso, string hoTen, string khoa, double diemTB, string? soDienThoai)
        {
            Maso = maso;
            HoTen = hoTen;
            Khoa = khoa;
            DiemTB = diemTB;
            SoDienThoai = soDienThoai;
        }

        public override string ToString()
        {
            string sdtHienThi = string.IsNullOrEmpty(SoDienThoai) ? "Chưa cập nhật" : SoDienThoai;
            return $"Mã số: {Maso} | Họ tên: {HoTen} | Khoa: {Khoa} | Điểm TB: {DiemTB:0.0} | SĐT: {sdtHienThi}";
        }
    }
}
