using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQA
{
    public partial class frmAddKH : Form
    {
        public frmAddKH()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void btnAddKHSave_Click(object sender, EventArgs e)
        {
            string qry = "EXEC InsertNewKhachHang @MaKH, @TenKH, @SDT";

            Hashtable ht = new Hashtable();
            ht.Add("@MaKH", textBoxAddMaKH.Text);
            ht.Add("@TenKH", textBoxAddTenKH.Text);
            ht.Add("@SDT", textBoxAddSDT.Text);

            if (My_DB.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Lưu thành công.");
                textBoxAddMaKH.Text = "";
                textBoxAddTenKH.Text = "";
                textBoxAddSDT.Text = "";
                textBoxAddMaKH.Focus();
                textBoxAddTenKH.Focus();
                textBoxAddSDT.Focus();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lưu thất bại.");
            }
        }

        private void btnAddKHCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
