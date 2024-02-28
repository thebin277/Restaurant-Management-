using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QuanLyQA
{
    public partial class frmThemNguyenLieu : Form
    {
        public frmThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            string maNL = txtMaNL.Text;
            string tenNL = txtTenNL.Text;
            string maNCC = txtMaNCC.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            string donVi = txtDonVi.Text;
            string tinhTrang = txtTinhTrang.Text;

            using (SqlConnection connection = new SqlConnection(My_DB.strCon))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand để gọi thủ tục SQL
                using (SqlCommand command = new SqlCommand("proc_themNguyenLieu", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho thủ tục SQL
                    command.Parameters.AddWithValue("@MaNL", maNL);
                    command.Parameters.AddWithValue("@TenNL", tenNL);
                    command.Parameters.AddWithValue("@MaNCC", maNCC);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@DonVi", donVi);
                    command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                    try
                    {
                        // Thực thi thủ tục SQL
                        command.ExecuteNonQuery();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Thêm nguyên liệu thành công");
                        frmKho form1 = Application.OpenForms["Form1"] as frmKho;
                        if (form1 != null)
                        {
                            form1.RefreshDataGridView();
                        }



                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi nếu có
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
