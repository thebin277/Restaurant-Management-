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
    public partial class DanhSachCa : Form
    {
        public DanhSachCa()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "Select * From v_CaLamViec";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaCa);
            lb.Items.Add(dgvNgayLam);
            lb.Items.Add(dgvGioBatDau);
            lb.Items.Add(dgvGioKetThuc);
            My_DB.LoadData(qry, dataGridViewShift, lb);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThemCaLam frm = new ThemCaLam();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            GetData();
        }

        private void DanhSachCa_Load(object sender, EventArgs e)
        {
            GetData();
        }

        
    }
}
