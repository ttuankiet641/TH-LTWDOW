using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_03
{
    public class Teacher : Person
    {
        public string ChuyenMon { get; set; } = "";

        public Teacher(string maSo, string hoTen, string khoa, string? soDienThoai, string chuyenMon)
            : base(maSo, hoTen, khoa, soDienThoai)
        {
            ChuyenMon = chuyenMon;
        }

        public override string ToString()
        {
            string sdtStr = string.IsNullOrEmpty(SoDienThoai) ? "Chưa cập nhật" : SoDienThoai;
            return $"Mã GV: {MaSo,-8} | Họ tên: {HoTen,-20} | Khoa: {Khoa,-15} | SĐT: {sdtStr,-15} | Chuyên môn: {ChuyenMon}";
        }
    }
}
