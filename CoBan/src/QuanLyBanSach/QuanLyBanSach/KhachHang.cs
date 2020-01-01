using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach
{
    public class KhachHang
    {
        const int GIA = 20000;

        public KhachHang()
        {
            HoTen = "Chua co ten";
        }

        public string HoTen { get; set; }
        public int SoLuongMua { get; set; }
        public bool LaSinhVien { get; set; }
        public double TinhTien 
        { 
            get 
            {
                if (LaSinhVien == true)
                    return (GIA * SoLuongMua) * 0.95;
                return GIA * SoLuongMua;
            } 
        }
    }
}
