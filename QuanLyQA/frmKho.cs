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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();  
        }
        public void GetDataKho()
        {
            string qry = "Select * FROM view_NguyenLieu";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaNL);
            lb.Items.Add(dgvTenNL);
            lb.Items.Add(dgvMaNCC);
            lb.Items.Add(dgvSL);
            lb.Items.Add(dgvDonVi);
            lb.Items.Add(dgvTinhTrang);

            My_DB.LoadData(qry, dgvKho, lb);
        }
        public void RefreshDataGridView()
        {
            GetDataKho();
            
        }
        public void GetDataPhieuChi()
        {
            string qry = "Select * FROM DonNhapHangView";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaDonNH);
            lb.Items.Add(dgvNgayNH);
            lb.Items.Add(dgvMaNCCPC);
            lb.Items.Add(dgvTinhTrangPC);
            lb.Items.Add(dgvMaPC);
            lb.Items.Add(dgvNgayXuatPhieu);
            lb.Items.Add(dgvMaNLPC);
            lb.Items.Add(dgvDonGiaPC);
            lb.Items.Add(dgvSLPC);
            lb.Items.Add(dgvDonViPC);
            lb.Items.Add(dgvSoTienChi);

            My_DB.LoadData(qry, dgvPhieuChi, lb);
        }
        private void kHOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        public void Form1_Load(object sender, EventArgs e)
        {
            GetDataKho();
            
        }


        private void btnAddNL_Click_1(object sender, EventArgs e)
        {
            frmThemNguyenLieu frmThemNguyenLieu = new frmThemNguyenLieu();
            frmThemNguyenLieu.ShowDialog();
        }

        private void tabKho_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
               
            }

        private void btnSearchNL_Click(object sender, EventArgs e)
        {
            string searchString = txtSearchKho.Text;

            // Tạo kết nối đến cơ sở dữ liệu SQL Server
            string connectionString = @"Data Source= LAPTOP-828J853G\SQLEXPRESS;Initial Catalog=QLQuanAn;Integrated Security=True; User ID=sa; Password=123456";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand để gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.func_getIngreListByString(@string)", connection))
                {
                    // Thêm tham số @string cho hàm SQL
                    command.Parameters.AddWithValue("@string", searchString);

                    // Thực thi câu truy vấn và lấy dữ liệu vào DataTable
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);

                    // Hiển thị kết quả tìm kiếm trong DataGridView 
                    dgvKho.DataSource = dt;
                }
            }
        }

        private void dgvPhieuChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GetDataPhieuChi();
        }
    }
    }

