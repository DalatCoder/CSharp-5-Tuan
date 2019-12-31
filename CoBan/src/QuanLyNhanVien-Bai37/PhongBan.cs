using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien_Bai37
{
    public class PhongBan
    {
        private List<NhanVien> _danhSachNhanVien;

        public PhongBan()
        {
            _danhSachNhanVien = new List<NhanVien>();
            MaPhongBan = 0;
            TenPhongBan = "Untitle";
            TruongPhong = new NhanVien();
        }

        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public NhanVien TruongPhong { get; set; }

        public bool ThemNhanVien(NhanVien nv)
        {
            bool trungMaNV = false;
            foreach (var nhanVien in _danhSachNhanVien)
            {
                if (nhanVien.MaNhanVien == nv.MaNhanVien)
                {
                    trungMaNV = true;
                    break;
                }
            }

            if (trungMaNV)
                return false;

            nv.TenPhongBan = this.TenPhongBan;
            // Them nhan vien vao danh sach
            _danhSachNhanVien.Add(nv);
            return true;
        }

        public void XuatToanBoNhanVien()
        {
            foreach (var nhanVien in _danhSachNhanVien)
            {
                Console.WriteLine(nhanVien);
            }
        }
    }
}
