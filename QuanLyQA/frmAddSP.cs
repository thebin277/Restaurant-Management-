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
    public partial class frmAddSP : Form
    {
        public frmAddSP()
        {
            InitializeComponent();
        }

        private void frmAddSP_Load(object sender, EventArgs e)
        {

        }


        public void btnAddSave_Click(object sender, EventArgs e)
        {
            string qry = "EXEC proc_themSanPhamMoi @MaSP, @TenSP, @DonGia, @TinhTrang, @MaLoaiSP";

            Hashtable ht = new Hashtable();
            ht.Add("@MaSP", textBoxAddMaSP.Text);
            ht.Add("@TenSP", textBoxAddTenSP.Text);
            ht.Add("@DonGia", textBoxAddDonGia.Text);
            ht.Add("@TinhTrang", comboBoxAddTT.Text);
            ht.Add("@MaLoaiSP", textBoxAddMaLSP.Text);

            if (My_DB.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Lưu thành công.");
                textBoxAddMaSP.Text = "";
                textBoxAddTenSP.Text = "";
                textBoxAddDonGia.Text = "";
                comboBoxAddTT.SelectedIndex = -1;
                textBoxAddMaLSP.Text = "";
                textBoxAddMaSP.Focus();
                textBoxAddTenSP.Focus();
                textBoxAddDonGia.Focus();
                comboBoxAddTT.Focus();
                textBoxAddMaLSP.Focus();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lưu thất bại.");
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddSP_Load_1(object sender, EventArgs e)
        {

        }
    }
}
