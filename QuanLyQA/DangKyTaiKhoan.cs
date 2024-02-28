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
    public partial class DangKyTaiKhoan : Form
    {
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*My_DB mydb = new My_DB();
            mydb.openConnectionAdmin();
            SqlCommand cmd = new SqlCommand("proc_ThemTaiKhoan", mydb.getConnectionAdmin);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@tk", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@mk", textBoxPassword.Text);
          

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Tạo tài khoản thành công");
                mydb.closeConnectionAdmin();
            }
            else
            {
                mydb.closeConnectionAdmin();
            }*/

            My_DB mydb = new My_DB();
            mydb.openConnectionAdmin();
            /*  String qry = "INSERT INTO DANGNHAP Values (@tk,@mk,@manv)";*/
            String qry = "INSERT INTO DANGNHAP Values (@tk,@mk,@manv)";

            SqlCommand cmd = new SqlCommand(qry, mydb.getConnectionAdmin);

            cmd.Parameters.AddWithValue("@tk", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@mk", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@manv", textBoxMaNV.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Không thể tạo tài khoản");
            }
            mydb.closeConnectionAdmin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
