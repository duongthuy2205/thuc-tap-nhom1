using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQL_NhanSu.entity;

namespace AppQL_NhanSu
{
    public partial class UC_PhongBan : UserControl
    {
        Model_NhanSu context = new Model_NhanSu();
        public UC_PhongBan()
        {
            InitializeComponent();
            loadPB();
        }
        void loadPB()
        {
            var query = from phongban in context.PhongBans select new { phongban.MaPb, phongban.TenPB, phongban.DiaChi, phongban.SDTPB };
            query.ToList();
            int index = -1;
            dataGridView1.Rows.Clear();
            foreach (var item in query)
            {
                dataGridView1.Rows.Add();
                index++;
                dataGridView1.Rows[index].Cells["STT"].Value = index + 1;
                dataGridView1.Rows[index].Cells["tenpb"].Value = item.TenPB;
                dataGridView1.Rows[index].Cells["mapb"].Value = item.MaPb;
                dataGridView1.Rows[index].Cells["sdt"].Value = item.SDTPB;
                dataGridView1.Rows[index].Cells["diachi"].Value = item.DiaChi;
            }
        }
        void addPB()
        {
           PhongBan pb = new PhongBan();
            pb.MaPb = textBox1.Text.ToString();
            pb.TenPB = textBox2.Text.ToString();
            pb.SDTPB = textBox3.Text.ToString();
            pb.DiaChi = textBox4.Text.ToString();
            var phongb = context.PhongBans.ToList();
            var check = context.PhongBans.Where(s => s.MaPb == pb.MaPb).SingleOrDefault();
            if (check == null)
            {
                context.PhongBans.Add(pb);
            }
            else
            {
                MessageBox.Show("phòng ban đã tồn tại mời nhập lại");
            }
            context.SaveChanges();
        }
        void editPB()
        {
            var phongban = dataGridView1.CurrentRow.Cells["mapb"].Value.ToString();
            PhongBan pbIndatabae = context.PhongBans.Single(s => s.MaPb.Equals(phongban));
            if (textBox1.Text != null && textBox1.Text.Length>0)
            {
                pbIndatabae.TenPB =textBox2.Text;
            }
            pbIndatabae.SDTPB = textBox3.Text;
            pbIndatabae.DiaChi = textBox4.Text;
            context.SaveChanges();
        }
        void removePB()
        {
            var phongban = context.PhongBans.Where(s => s.MaPb.Equals(textBox1.Text)).SingleOrDefault();
            if (phongban != null)
            {
                context.PhongBans.Remove(phongban);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("không tồn tại phong ban như thế");
            }

        }
        void searchPB()
        {
            var lst = from pb in context.PhongBans where pb.TenPB.Contains(textBox5.Text.ToString()) select new { mapb = pb.MaPb, tenpb = pb.TenPB, sdt = pb.SDTPB, dc = pb.DiaChi };
            int index = -1;
            dataGridView1.Rows.Clear();
            foreach (var item in lst)
            {
                dataGridView1.Rows.Add();
                index++;
                dataGridView1.Rows[index].Cells["STT"].Value = index + 1;
                dataGridView1.Rows[index].Cells["tenpb"].Value = item.tenpb;
                dataGridView1.Rows[index].Cells["mapb"].Value = item.mapb;
                dataGridView1.Rows[index].Cells["sdt"].Value = item.sdt;
                dataGridView1.Rows[index].Cells["diachi"].Value = item.dc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPB();
            loadPB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                editPB();
                loadPB();
                MessageBox.Show("Cập Nhật Thành Công");
            }
            catch
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                removePB();
                loadPB();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchPB();
        }

        private void chosedaata(object sender, DataGridViewCellEventArgs e)
        {
            var phongban = dataGridView1.CurrentRow.Cells["mapb"].Value.ToString();
            PhongBan pbIndatabae = context.PhongBans.Single(s => s.MaPb.Equals(phongban));
            textBox1.Text = pbIndatabae.MaPb;
            textBox2.Text = pbIndatabae.TenPB;
            textBox3.Text = pbIndatabae.SDTPB;
            textBox4.Text = pbIndatabae.DiaChi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadPB();
        }
    }
}
