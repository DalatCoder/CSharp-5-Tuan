using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai33
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDM = txtMaDM.Text;
            dm.TenDM = txtTenDM.Text;
            frmSanPham.danhSachDM.Add(dm);
            HienThiDanhMucLenListBox();

            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtMaDM.Focus();
            frmSanPham.CoThayDoi = true;
        }
        void HienThiDanhMucLenListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach(DanhMuc dm in frmSanPham.danhSachDM)
            {
                lstDanhMuc.Items.Add(dm);
            }
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDanhMuc.SelectedIndex!=-1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDM.Text = dm.MaDM;
                txtTenDM.Text = dm.TenDM;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstDanhMuc.SelectedIndex!=-1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                lstDanhMuc.Items.Remove(dm);
                frmSanPham.danhSachDM.Remove(dm);
                frmSanPham.CoThayDoi = true;
                txtMaDM.Text = "";
                txtTenDM.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (frmSanPham.CoThayDoi == true)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
    }
}
