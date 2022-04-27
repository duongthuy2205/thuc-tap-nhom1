using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQL_NhanSu
{
    public partial class Form2 : Form
    {
        UC_Luong luong;
        UC_NhanVien1 nhanvien;         
        UC_PhongBan phongban;
        UC_ChucVu chucvu;
        void lb_UserName()
        {
            lb_userName.Text = "chung";
        }
        public Form2()
        {
            InitializeComponent();
            lb_UserName();
            luong = new UC_Luong();
            nhanvien = new UC_NhanVien1();
            phongban = new UC_PhongBan();
            chucvu = new UC_ChucVu();

        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
                SilePanel.Height = btn_NhanVien.Height;
                SilePanel.Top = btn_NhanVien.Top;
            if (!panel2.Controls.Contains(nhanvien))
            {
                panel2.Controls.Add(nhanvien);
                nhanvien.Dock = DockStyle.Fill;
                nhanvien.BringToFront();
            }
            else
                nhanvien.BringToFront();
        }

        private void btn_PhongBan_Click(object sender, EventArgs e)
        {
                SilePanel.Height = btn_PhongBan.Height;
                SilePanel.Top = btn_PhongBan.Top;
            if (!panel2.Controls.Contains(phongban))
            {
                panel2.Controls.Add(phongban);
                phongban.Dock = DockStyle.Fill;
                phongban.BringToFront();
            }
            else
                phongban.BringToFront();
        }

        private void btn_Luong_Click(object sender, EventArgs e)
        {
                SilePanel.Height = btn_Luong.Height;
                SilePanel.Top = btn_Luong.Top;
            if (!panel2.Controls.Contains(luong))
            {
                panel2.Controls.Add(luong);
                luong.Dock = DockStyle.Fill;
                luong.BringToFront();
            }
            else
                luong.BringToFront();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SilePanel.Height = btn_ChucVu.Height;
                SilePanel.Top = btn_ChucVu.Top;
            if (!panel2.Controls.Contains(chucvu))
            {
                panel2.Controls.Add(chucvu);
                chucvu.Dock = DockStyle.Fill;
                chucvu.BringToFront();
            }
            else
                chucvu.BringToFront();
        }
    }
}
