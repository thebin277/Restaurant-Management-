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
    public partial class frmEditSP : Form
    {
        public frmEditSP()
        {
            InitializeComponent();
        }

        private void frmEditSP_Load(object sender, EventArgs e)
        {

        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            string qry = "EXEC proc_suaSanPham @MaSP, @TenSP, @DonGia, @TinhTrang, @MaLoaiSP";

            Hashtable ht = new Hashtable();
            ht.Add("@MaSP", textBoxEditMaSP.Text);
            ht.Add("@TenSP", textBoxEditTenSP.Text);
            ht.Add("@DonGia", textBoxEditDonGia.Text);
            ht.Add("@TinhTrang", comboBoxEditTT.Text);
            ht.Add("@MaLoaiSP", textBoxEditMaLSP.Text);

            if (My_DB.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại.");
            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
