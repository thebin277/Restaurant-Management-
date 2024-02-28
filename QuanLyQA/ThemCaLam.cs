using System;
using System.Collections;
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
    public partial class ThemCaLam : Form
    {
        public ThemCaLam()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMaCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "EXEC proc_AddBangPhanCa @MaCa, @NgayLam, @GioBatDau, @GioKetThuc";
            Hashtable ht = new Hashtable();
            ht.Add("@MaCa", comboBoxMaCa.Text);
            ht.Add("@NgayLam", dateTimeNgayLam.Text);
            ht.Add("@GioBatDau", textBoxMaNV.Text);
            ht.Add("@GioKetThuc", textBoxMaNV.Text);

            if (My_DB.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Thêm ca làm việc thành công!");
                textBoxMaNV.Focus();
                dateTimeNgayLam.Focus();
                comboBoxMaCa.Focus();
            }
            else
            {
                MessageBox.Show("Thêm ca làm việc thất bại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
