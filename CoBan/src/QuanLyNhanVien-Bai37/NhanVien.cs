using System;
using System.Text;

namespace QuanLyNhanVien_Bai37
{
    public class NhanVien
    {
        public const int LUONG_CO_BAN = 10000000;

        public NhanVien()
        {
            MaNhanVien = 0;
            TenNhanVien = "Untitle";
            NgaySinh = new DateTime(1990, 1, 1);
            ChucVu = LoaiChucVu.NHAN_VIEN;
            TenPhongBan = "Untitle";
        }

        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public LoaiChucVu ChucVu { get; set; }
        public String TenPhongBan { get; set; }

        public long TinhLuong
        {
            get
            {
                double tiLe = 1.0;

                switch (ChucVu)
                {
                    case LoaiChucVu.GIAM_DOC:
                        tiLe = 1.25;
                        break;
                    case LoaiChucVu.TRUONG_PHONG:
                        tiLe = 1.15;
                        break;
                    case LoaiChucVu.PHO_PHONG:
                        tiLe = 1.05;
                        break;
                }

                return (long)(LUONG_CO_BAN * tiLe);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ma nhan vien: {this.MaNhanVien}");
            sb.AppendLine($"Ten nhan vien: {this.TenNhanVien}");
            sb.AppendLine($"Ngay thang nam sinh: {this.NgaySinh:D}");
            sb.AppendLine($"Phong ban: {this.TenPhongBan}");
            sb.AppendLine($"Tien luong: {this.TinhLuong}");
            return sb.ToString();
        }
    }
}
