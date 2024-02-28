using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyQA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
          
            DangKyTaiKhoan frm = new DangKyTaiKhoan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }*/

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            Global.username = textBoxUser.Text;
            Global.password = textBoxPassword.Text;
            My_DB mydb = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT dbo.checkLogin(@user, @pass)",
            mydb.getConnectionAdmin);
            cmd.Parameters.AddWithValue("@user", textBoxUser.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);
            mydb.openConnectionAdmin();
            bool count = (bool)cmd.ExecuteScalar();
            mydb.closeConnectionAdmin();
            if (count) // Kiểm tra tên người dùng và mật khẩu
            {
                this.Hide(); 
                Home frm = new Home(); 
                frm.Show(); 
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai. Vui lòng đăng nhập lại!"); 
            }
        }


    }
}
