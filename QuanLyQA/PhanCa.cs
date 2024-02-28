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
    public partial class PhanCa : Form
    {
        public PhanCa()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * From v_BangPhanCa";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaNV);
            lb.Items.Add(dgvHoNV);
            lb.Items.Add(dgvTenNV);
            lb.Items.Add(dgvMaCa);
            lb.Items.Add(dgvNgayLam);
            My_DB.LoadData(qry, dataGridView_Division, lb);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachCa frm = new DanhSachCa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            PhanCaNV frm = new PhanCaNV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            GetData();
        }

        private void dataGridView_Division_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Division.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                string maNV = Convert.ToString(dataGridView_Division.CurrentRow.Cells["dgvMaNV"].Value);
                string maCa = Convert.ToString(dataGridView_Division.CurrentRow.Cells["dgvMaCa"].Value);
                string ngayLam = Convert.ToString(dataGridView_Division.CurrentRow.Cells["dgvNgayLam"].Value);

                // Sử dụng tham số để tránh các vấn đề bảo mật và lỗi SQL Injection.
                /*string qry = "EXEC proc_XoaPhanCa WHERE MaNV = @MaNV AND HoNV = @HoNV AND TenNV = @TenNV AND MaCa = @MaCa AND NgayLam = @NgayLam";*/
                string qry = "EXEC proc_XoaPhanCa @manv, @maca, @ngay";

                Hashtable ht = new Hashtable();
                ht.Add("@manv", maNV);
                ht.Add("@maca", maCa);
                ht.Add("@ngay", ngayLam);
                // Thực hiện truy vấn SQL với tham số.
                int rowsAffected = My_DB.SQL(qry, ht);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
                GetData();
            }
        }
        private void PhanCa_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView_Division_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
