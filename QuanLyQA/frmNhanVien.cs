using System;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        Modify modify;
        NhanVien nhanVien;
        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " +ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Them_NV_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = this.txt_MaNV.Text;
                string ho = this.txt_HoNV.Text;
                string ten = this.txt_TenNV.Text;
                string gt = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
                DateTime ns = this.dateTimePicker_NgaySinh.Value;
                string dc = this.txt_DiaChi.Text;
                string sdt = this.txt_SDT.Text;
                string macv = this.txt_MaCV.Text;
                string soca = this.txt_SoCa.Text;
                string thuong = this.txt_Thuong.Text;
                DateTime ntd = this.dateTimePicker_NgayTD.Value;
                nhanVien = new NhanVien(manv, ho, ten, gt, ns, dc, sdt, macv, soca, thuong, ntd);
                if (modify.insert(nhanVien))
                {
                    dataGridView1.DataSource = modify.getAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vao được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            string manv = this.txt_MaNV.Text;
            string ho = this.txt_HoNV.Text;
            string ten = this.txt_TenNV.Text;
            string gt = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime ns = this.dateTimePicker_NgaySinh.Value;
            string dc = this.txt_DiaChi.Text;
            string sdt = this.txt_SDT.Text;
            string macv = this.txt_MaCV.Text;
            string soca = this.txt_SoCa.Text;
            string thuong = this.txt_Thuong.Text;
            DateTime ntd = this.dateTimePicker_NgayTD.Value;
            nhanVien = new NhanVien(manv, ho, ten, gt, ns, dc, sdt, macv, soca, thuong, ntd);
            if (modify.update(nhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            string manv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(modify.delete(manv))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BangLuong_Click(object sender, EventArgs e)
        {
            BangTinhLuong frm = new BangTinhLuong();
            frm.ShowDialog();
        }
    }
}
