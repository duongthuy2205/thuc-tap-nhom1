using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQL_NhanSu.entity;

namespace AppQL_NhanSu
{
    public partial class UC_ChucVu : UserControl
    {
        Model_NhanSu context = new Model_NhanSu();
        public UC_ChucVu()
        {
            InitializeComponent();
            loadcv();
        }
        void loadcv()
        {
            var cv = from chucvu in context.CHUCVUs select new { macv = chucvu.MaCV, ten = chucvu.TenCV };
            cv.ToList();
            int index = -1;
            dataGridView1.Rows.Clear();
            foreach(var item in cv)
            {
                dataGridView1.Rows.Add(item);
                index++;
                dataGridView1.Rows[index].Cells["STT"].Value = index + 1;
                dataGridView1.Rows[index].Cells["macv"].Value = item.macv;
                dataGridView1.Rows[index].Cells["tencv"].Value = item.ten;
            }
        }

        void add()
        {
            CHUCVU chucvu = new CHUCVU();
            chucvu.MaCV = textBox1.Text;
            chucvu.TenCV = textBox2.Text;
            var cvIndatabase = context.CHUCVUs.Where(s => s.MaCV == chucvu.MaCV).SingleOrDefault();
            if(cvIndatabase == null)
            {
                context.CHUCVUs.Add(chucvu);
            }
            else
            {
                MessageBox.Show("Chức Vụ Đã Tồn Tại Mời Bạn Nhập Lại");
            }
                context.SaveChanges();
        }
        void edit()
        {
            var chucvu = dataGridView1.CurrentRow.Cells["macv"].Value.ToString();
            CHUCVU cvIndatabase = context.CHUCVUs.Single(s => s.MaCV.Equals(chucvu));
            if (textBox1.Text.Length > 0 && textBox1.Text != null)
            {
                cvIndatabase.TenCV = textBox2.Text;
            }
            context.SaveChanges();
        }
        void remove()
        {
            var cv = context.CHUCVUs.Where(s => s.MaCV.Equals(textBox1.Text)).SingleOrDefault();
            if (cv != null)
            {
                context.CHUCVUs.Remove(cv);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Chức Vụ bạn Xóa Không Tồn Tại");
            }
        }

        private void ChooseData(object sender, DataGridViewCellEventArgs e)
        {
            var chucvu = dataGridView1.CurrentRow.Cells["macv"].Value.ToString();
            CHUCVU cvIndatabase = context.CHUCVUs.Single(s => s.MaCV.Equals(chucvu));
            textBox1.Text = cvIndatabase.MaCV;
            textBox2.Text = cvIndatabase.TenCV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
            loadcv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                edit();
                loadcv();
                MessageBox.Show("Cập Nhật Thành Công");
            }
            catch
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Thông Báo", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                remove();
                loadcv();
            }
        }
    }
}
