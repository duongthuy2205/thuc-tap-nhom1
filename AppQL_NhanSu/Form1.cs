using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppQL_NhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Initial Catalog=QL_NhanSu;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    string user = txtUsername.Text;
            //    string pass = txtPassword.Text;
            //    string sql = "SELECT * FROM dbo.log_in WHERE email ='" + user + "'and password ='" + pass + "';";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader dta = cmd.ExecuteReader();
            //    if (dta.Read() == true)
            //    {
            //        Form2 form2 = new Form2();
            //        Hide();
            //        form2.ShowDialog();
            //        Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Lỗi kết nối");
            //}
            Form2 form2 = new Form2();
            Hide();
            form2.ShowDialog();
            Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
