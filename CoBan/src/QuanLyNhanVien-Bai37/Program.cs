using System;

namespace QuanLyNhanVien_Bai37
{
    public class Program
    {
        private static void TestQLNS()
        {
            var phongNhanSu = new PhongBan()
            {
                TenPhongBan = "Phong Nhan Su",
                MaPhongBan = 1
            };

            for (int i = 0; i < 5; i++)
                phongNhanSu.ThemNhanVien(new NhanVien() { MaNhanVien = i });

            phongNhanSu.XuatToanBoNhanVien();
        }

        static void Main(string[] args)
        {
            TestQLNS();
        }
    }
}
