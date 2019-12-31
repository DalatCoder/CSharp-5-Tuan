using System;
using System.Collections.Generic;

namespace QuanLyNhanVien_Bai37
{
    public class Program
    {
        private static List<PhongBan> _danhSachPhongBan = new List<PhongBan>();

        private static void TestQLNS()
        {
            var phongNhanSu = new PhongBan()
            {
                TenPhongBan = "Phong Nhan Su",
                MaPhongBan = 1
            };
            _danhSachPhongBan.Add(phongNhanSu);

            var phongKeToan = new PhongBan()
            {
                TenPhongBan = "Phong Ke Toan",
                MaPhongBan = 2
            };
            _danhSachPhongBan.Add(phongKeToan);

            ThemNhanVienPhongNhanSu(phongNhanSu);
            ThemNhanVienPhongKeToan(phongKeToan);

            foreach (var phongBan in _danhSachPhongBan)
            {
                System.Console.WriteLine($"Ten phong ban: {phongBan.TenPhongBan}");
                phongBan.XuatToanBoNhanVien();
            }
        }

        static void Main(string[] args)
        {
            TestQLNS();
        }

        private static void ThemNhanVienPhongKeToan(PhongBan phongKeToan)
        {
            var nv1 = new NhanVien()
            {
                MaNhanVien = 0,
                TenNhanVien = "Nguyen Van Ke Toan",
                ChucVu = LoaiChucVu.TRUONG_PHONG
            };
            phongKeToan.ThemNhanVien(nv1);

            for (int i = 0; i < 5; i++)
                phongKeToan.ThemNhanVien(new NhanVien() { MaNhanVien = i });
        }

        private static void ThemNhanVienPhongNhanSu(PhongBan phongNhanSu)
        {
            var nv1 = new NhanVien()
            {
                MaNhanVien = 0,
                TenNhanVien = "Nguyen Van Nhan Su",
                ChucVu = LoaiChucVu.TRUONG_PHONG
            };
            phongNhanSu.ThemNhanVien(nv1);

            for (int i = 0; i < 5; i++)
                phongNhanSu.ThemNhanVien(new NhanVien() { MaNhanVien = i });
        }
    }
}
