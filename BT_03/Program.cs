using BT_03;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_03
{
    class Program
    {
        static List<Student> danhSachSV = new List<Student>();
        static List<Teacher> danhSachGV = new List<Teacher>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("\n===== QUAN LY SINH VIEN VA GIANG VIEN =====");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them giao vien");
                Console.WriteLine("3. Xuat danh sach sinh vien");
                Console.WriteLine("4. Xuat danh sach giao vien");
                Console.WriteLine("5. So luong tung danh sach");
                Console.WriteLine("6. Xuat danh sach sinh vien thuoc khoa \"CNTT\"");
                Console.WriteLine("7. Xuat danh sach giao vien co chuyen mon chua \"Lap trinh\"");
                Console.WriteLine("8. Xuat sinh vien co diem trung binh cao nhat va thuoc khoa \"CNTT\"");
                Console.WriteLine("9. Thong ke so luong theo tung xep loai hoc luc");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                string? luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1": ThemSinhVien(); break;
                    case "2": ThemGiaoVien(); break;
                    case "3": XuatDanhSachSV(); break;
                    case "4": XuatDanhSachGV(); break;
                    case "5": ThongKeSoLuong(); break;
                    case "6": XuatSVKhoaCNTT(); break;
                    case "7": XuatGVChenMonLapTrinh(); break;
                    case "8": XuatSVDiemTBCaoNhatCNTT(); break;
                    case "9": ThongKeTheoXepLoai(); break;
                    case "0": tiepTuc = false; break;
                    default: Console.WriteLine("=> Lựa chọn không hợp lệ!"); break;
                }

                if (tiepTuc)
                {
                    Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            }
        }

        static bool KiemTraTrungMaSo(string maSo)
        {
            return danhSachSV.Any(x => x.MaSo.Equals(maSo, StringComparison.OrdinalIgnoreCase)) ||
                   danhSachGV.Any(x => x.MaSo.Equals(maSo, StringComparison.OrdinalIgnoreCase));
        }

        static double NhapSoThuc(string thongBao, double min, double max)
        {
            double gtri;
            while (true)
            {
                Console.Write(thongBao);
                if (double.TryParse(Console.ReadLine(), out gtri) && gtri >= min && gtri <= max)
                    return gtri;
                Console.WriteLine($"=> Giá trị không hợp lệ, vui lòng nhập lại (từ {min} đến {max}).");
            }
        }

        static void ThemSinhVien()
        {
            Console.WriteLine("\n--- THEM SINH VIEN ---");
            string maSo;
            while (true)
            {
                Console.Write("Mã sinh viên: ");
                maSo = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(maSo))
                {
                    Console.WriteLine("Mã số không được để trống!");
                    continue;
                }
                if (KiemTraTrungMaSo(maSo))
                {
                    Console.WriteLine("=> Mã số đã tồn tại trong hệ thống! Vui lòng nhập mã khác.");
                    continue;
                }
                break;
            }

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine() ?? "";
            Console.Write("Khoa: ");
            string khoa = Console.ReadLine() ?? "";

            Console.Write("Số điện thoại (có thể bỏ trống): ");
            string sdtInput = Console.ReadLine();
            string? sdt = string.IsNullOrWhiteSpace(sdtInput) ? null : sdtInput;

            double diemTB = NhapSoThuc("Điểm trung bình (0.0 - 10.0): ", 0.0, 10.0);

            danhSachSV.Add(new Student(maSo, hoTen, khoa, sdt, diemTB));
            Console.WriteLine("=> Thêm sinh viên thành công!");
        }

        static void ThemGiaoVien()
        {
            Console.WriteLine("\n--- THEM GIANG VIEN ---");
            string maSo;
            while (true)
            {
                Console.Write("Mã giảng viên: ");
                maSo = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(maSo))
                {
                    Console.WriteLine("Mã số không được để trống!");
                    continue;
                }
                if (KiemTraTrungMaSo(maSo))
                {
                    Console.WriteLine("=> Mã số đã tồn tại trong hệ thống! Vui lòng nhập mã khác.");
                    continue;
                }
                break;
            }

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine() ?? "";
            Console.Write("Khoa: ");
            string khoa = Console.ReadLine() ?? "";

            Console.Write("Số điện thoại (có thể bỏ trống): ");
            string sdtInput = Console.ReadLine();
            string? sdt = string.IsNullOrWhiteSpace(sdtInput) ? null : sdtInput;

            Console.Write("Chuyên môn: ");
            string chuyenMon = Console.ReadLine() ?? "";

            danhSachGV.Add(new Teacher(maSo, hoTen, khoa, sdt, chuyenMon));
            Console.WriteLine("=> Thêm giảng viên thành công!");
        }

        static void XuatDanhSachSV()
        {
            Console.WriteLine("\n--- DANH SACH SINH VIEN ---");
            if (!danhSachSV.Any())
            {
                Console.WriteLine("(Không có dữ liệu)");
                return;
            }
            foreach (var sv in danhSachSV)
                Console.WriteLine(sv);
        }

        static void XuatDanhSachGV()
        {
            Console.WriteLine("\n--- DANH SACH GIANG VIEN ---");
            if (!danhSachGV.Any())
            {
                Console.WriteLine("(Không có dữ liệu)");
                return;
            }
            foreach (var gv in danhSachGV)
                Console.WriteLine(gv);
        }

        static void ThongKeSoLuong()
        {
            Console.WriteLine("\n--- THONG KE SO LUONG ---");
            Console.WriteLine($"Tổng số sinh viên: {danhSachSV.Count}");
            Console.WriteLine($"Tổng số giảng viên: {danhSachGV.Count}");
        }

        static void XuatSVKhoaCNTT()
        {
            Console.WriteLine("\n--- DANH SACH SINH VIEN KHOA CNTT ---");
            var dsCNTT = danhSachSV.Where(x => x.Khoa.Equals("CNTT", StringComparison.OrdinalIgnoreCase)).ToList();
            if (!dsCNTT.Any())
            {
                Console.WriteLine("(Không tìm thấy sinh viên khoa CNTT)");
                return;
            }
            foreach (var sv in dsCNTT)
                Console.WriteLine(sv);
        }

        static void XuatGVChenMonLapTrinh()
        {
            Console.WriteLine("\n--- GIANG VIEN CO CHUYEN MON CHUA \"LAP TRINH\" ---");
            var dsGV = danhSachGV.Where(x => x.ChuyenMon.Contains("Lap trinh", StringComparison.OrdinalIgnoreCase)).ToList();
            if (!dsGV.Any())
            {
                Console.WriteLine("(Không tìm thấy giảng viên phù hợp)");
                return;
            }
            foreach (var gv in dsGV)
                Console.WriteLine(gv);
        }

        static void XuatSVDiemTBCaoNhatCNTT()
        {
            Console.WriteLine("\n--- SINH VIEN KHOA CNTT CO DIEM TB CAO NHAT ---");
            var dsCNTT = danhSachSV.Where(x => x.Khoa.Equals("CNTT", StringComparison.OrdinalIgnoreCase)).ToList();
            if (!dsCNTT.Any())
            {
                Console.WriteLine("(Không có sinh viên khoa CNTT)");
                return;
            }
            double maxDiem = dsCNTT.Max(x => x.DiemTB);
            var topSV = dsCNTT.Where(x => x.DiemTB == maxDiem);
            foreach (var sv in topSV)
                Console.WriteLine(sv);
        }

        static string XepLoai(double diem)
        {
            if (diem >= 9.0) return "Xuất sắc";
            if (diem >= 8.0) return "Giỏi";
            if (diem >= 6.5) return "Khá";
            if (diem >= 5.0) return "Trung bình";
            return "Yếu";
        }

        static void ThongKeTheoXepLoai()
        {
            Console.WriteLine("\n--- THONG KE XEP LOAI HOC LUC SINH VIEN ---");
            if (!danhSachSV.Any())
            {
                Console.WriteLine("(Không có dữ liệu sinh viên)");
                return;
            }

            var thongKe = danhSachSV
                .GroupBy(x => XepLoai(x.DiemTB))
                .Select(g => new { XepLoai = g.Key, SoLuong = g.Count() });

            foreach (var item in thongKe)
            {
                Console.WriteLine($"Xếp loại: {item.XepLoai,-12} | Số lượng: {item.SoLuong}");
            }
        }
    }
}