using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class Form1 : Form
    {
        private DanhSachKhachHang khachHangs = new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
                MessageBox.Show
                    (
                        "Chưa điền đủ thông tin", 
                        "Thiếu thông tin", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );

            try
            {
                var khachHangMoi = new KhachHang();
                khachHangMoi.HoTen = txtTenKH.Text;
                khachHangMoi.SoLuongMua = int.Parse(txtSoLuong.Text);
                if (khachHangMoi.SoLuongMua <= 0)
                    throw new Exception();
                khachHangMoi.LaSinhVien = chkLaSV.Checked;

                lblThanhTien.Text = khachHangMoi.TinhTien.ToString();
                khachHangs.ThemKhachHang(khachHangMoi);
            } catch
            {
                MessageBox.Show
                    (
                        "Số lượng nhập vào không hợp lệ",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void InitForm()
        {
            txtSoLuong.Text = "";
            txtTenKH.Text = "";
            txtTongDoanhThu.Text = "";
            txtTongKH.Text = "";
            txtTongKHSV.Text = "";
            lblThanhTien.Text = "";
            chkLaSV.Checked = false;
        }

        private void btnNguoiTiepTheo_Click(object sender, EventArgs e)
        {
            InitForm();
            txtTenKH.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            InitForm();
            txtTongDoanhThu.Text = khachHangs.TongDoanhThu.ToString();
            txtTongKH.Text = khachHangs.TongSoKhachHang.ToString();
            txtTongKHSV.Text = khachHangs.TongSoKhachHangLaSV.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show
                (
                    "Bạn có chắc chắn muốn thoát", 
                    "Thoát", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
                Close();
        }

        private void txtTongKH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var frmKH = new Form();
            frmKH.Width = frmKH.Height = 300;
            frmKH.Text = "Danh sách toàn bộ khách hàng";
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            
            var lstKH = new ListBox();
            frmKH.Controls.Add(lstKH);
            lstKH.Dock = DockStyle.Fill;

            foreach(var khachHang in khachHangs.KhachHangs)
            {
                lstKH.Items.Add(khachHang.HoTen);
            }

            frmKH.Show();
        }

        private void txtTongKHSV_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var frmKH = new Form();
            frmKH.Width = frmKH.Height = 300;
            frmKH.Text = "Danh sách khách hàng SV";
            frmKH.StartPosition = FormStartPosition.CenterScreen;

            var lstKH = new ListBox();
            frmKH.Controls.Add(lstKH);
            lstKH.Dock = DockStyle.Fill;

            foreach (var khachHang in khachHangs.KhachHangs)
            {
                if (khachHang.LaSinhVien)
                    lstKH.Items.Add(khachHang.HoTen);
            }

            frmKH.Show();
        }
    }
}
