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
            TenPhongBan = "Untitled";
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

        public NhanVien TimNhanVien(int maNV)
        {
            foreach (var nhanVien in this._danhSachNhanVien)
            {
                if (nhanVien.MaNhanVien == maNV)
                    return nhanVien;
            }
            return null;
        }

        public bool XoaNhanVien(int maNV)
        {
            var nv = TimNhanVien(maNV);
            if (nv == null) return false;

            _danhSachNhanVien.Remove(nv);
            return true;
        }

        private int SoSanhNhanVien(NhanVien nv1, NhanVien nv2)
        {
            var kqSS = string.Compare(nv1.TenNhanVien, nv2.TenNhanVien, true);

            // Trung ten, sap xep giam dan theo ma nhan vien
            if (kqSS == 0)
            {
                if (nv1.MaNhanVien < nv2.MaNhanVien)
                    return 1;
                if (nv1.MaNhanVien > nv2.MaNhanVien)
                    return -1;
                return 0;
            }
            return kqSS;
        }

        public void SapXepTheoTen()
        {
            _danhSachNhanVien.Sort(SoSanhNhanVien);
        }
    }
}
