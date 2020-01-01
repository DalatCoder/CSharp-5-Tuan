using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach
{
    public class DanhSachKhachHang
    {
        public List<KhachHang> KhachHangs { get; set; }

        public DanhSachKhachHang()
        {
            KhachHangs = new List<KhachHang>();
        }

        public void ThemKhachHang(KhachHang khachHangMoi)
        {
            KhachHangs.Add(khachHangMoi);
        }
        public int TongSoKhachHang 
        { 
            get
            {
                return KhachHangs.Count;
            }
        }
        public int TongSoKhachHangLaSV
        {
            get
            {
                int count = 0;
                foreach (var khachHang in KhachHangs)
                    if (khachHang.LaSinhVien)
                        count += 1;
                return count;
            }
        }
        public double TongDoanhThu 
        {
            get
            {
                double sum = 0;
                foreach (var khachHang in KhachHangs)
                    sum += khachHang.TinhTien;
                return sum;
            }
        }
    }
}
