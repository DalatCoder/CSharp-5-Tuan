﻿namespace QuanLyBanSach
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLaSV = new System.Windows.Forms.CheckBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNguoiTiepTheo = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.txtTongKHSV = new System.Windows.Forms.TextBox();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TIỀN BÁN SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkLaSV);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(66, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThanhTien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblThanhTien.Location = new System.Drawing.Point(204, 180);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(325, 30);
            this.lblThanhTien.TabIndex = 6;
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành tiền";
            // 
            // chkLaSV
            // 
            this.chkLaSV.AutoSize = true;
            this.chkLaSV.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLaSV.Location = new System.Drawing.Point(23, 135);
            this.chkLaSV.Name = "chkLaSV";
            this.chkLaSV.Size = new System.Drawing.Size(196, 29);
            this.chkLaSV.TabIndex = 4;
            this.chkLaSV.Text = "Khách hàng là SV:";
            this.chkLaSV.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(204, 84);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(325, 30);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(204, 38);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(325, 30);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThongKe);
            this.groupBox2.Controls.Add(this.btnNguoiTiepTheo);
            this.groupBox2.Controls.Add(this.btnTinhTien);
            this.groupBox2.Location = new System.Drawing.Point(66, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(410, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(281, 24);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(117, 34);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNguoiTiepTheo
            // 
            this.btnNguoiTiepTheo.Location = new System.Drawing.Point(152, 24);
            this.btnNguoiTiepTheo.Name = "btnNguoiTiepTheo";
            this.btnNguoiTiepTheo.Size = new System.Drawing.Size(117, 34);
            this.btnNguoiTiepTheo.TabIndex = 1;
            this.btnNguoiTiepTheo.Text = "Mới";
            this.btnNguoiTiepTheo.UseVisualStyleBackColor = true;
            this.btnNguoiTiepTheo.Click += new System.EventHandler(this.btnNguoiTiepTheo_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(23, 24);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(117, 34);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongDoanhThu);
            this.groupBox3.Controls.Add(this.txtTongKHSV);
            this.groupBox3.Controls.Add(this.txtTongKH);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(66, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 170);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(296, 116);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(233, 30);
            this.txtTongDoanhThu.TabIndex = 5;
            this.txtTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongKHSV
            // 
            this.txtTongKHSV.Location = new System.Drawing.Point(296, 76);
            this.txtTongKHSV.Name = "txtTongKHSV";
            this.txtTongKHSV.ReadOnly = true;
            this.txtTongKHSV.Size = new System.Drawing.Size(233, 30);
            this.txtTongKHSV.TabIndex = 3;
            this.txtTongKHSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTongKHSV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTongKHSV_MouseDoubleClick_1);
            // 
            // txtTongKH
            // 
            this.txtTongKH.Location = new System.Drawing.Point(296, 36);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.ReadOnly = true;
            this.txtTongKH.Size = new System.Drawing.Size(233, 30);
            this.txtTongKH.TabIndex = 1;
            this.txtTongKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTongKH.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtTongKH.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTongKH_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng số khách hàng là SV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số Khách hàng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkLaSV;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNguoiTiepTheo;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongKHSV;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

