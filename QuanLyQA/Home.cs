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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public void GetDSSP()
        {
            string qry = "Select * From v_DanhSachSP";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSP);
            lb.Items.Add(dgvTenSP);
            lb.Items.Add(dgvDonGia);
            lb.Items.Add(dgvTinhTrang);
            lb.Items.Add(dgvMaLoaiSP);

            My_DB.LoadData(qry, dataGridViewSP, lb);
        }

        public void GetDSSPMy()
        {
            string qry = "Select * From v_DanhSachSP where MaLoaiSP = 'LoaiMy'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSPMy);
            lb.Items.Add(dgvTenSPMy);
            lb.Items.Add(dgvDonGiaMy);
            lb.Items.Add(dgvTTMy);
            lb.Items.Add(dgvMaLSPMy);

            My_DB.LoadData(qry, dataGridViewMy, lb);
        }
        public void GetDSSPPho()
        {
            string qry = "Select * From v_DanhSachSP where MaLoaiSP = 'LoaiPho'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSPPho);
            lb.Items.Add(dgvTenSPPho);
            lb.Items.Add(dgvDonGiaPho);
            lb.Items.Add(dgvTTPho);
            lb.Items.Add(dgvMaLSPPho);

            My_DB.LoadData(qry, dataGridViewPho, lb);
        }
        public void GetDSSPCom()
        {
            string qry = "Select * From v_DanhSachSP where MaLoaiSP = 'LoaiCom'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSPCom);
            lb.Items.Add(dgvTenSPCom);
            lb.Items.Add(dgvDonGiaCom);
            lb.Items.Add(dgvTTCom);
            lb.Items.Add(dgvMaLSPCom);

            My_DB.LoadData(qry, dataGridViewCom, lb);
        }
        public void GetDSSPBun()
        {
            string qry = "Select * From v_DanhSachSP where MaLoaiSP = 'LoaiBun'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSPBun);
            lb.Items.Add(dgvTenSPBun);
            lb.Items.Add(dgvDonGiaBun);
            lb.Items.Add(dgvTTBun);
            lb.Items.Add(dgvMaLSPBun);

            My_DB.LoadData(qry, dataGridViewBun, lb);
        }
        public void GetDSSPNuoc()
        {
            string qry = "Select * From v_DanhSachSP where MaLoaiSP = 'LoaiNuoc'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSPNuoc);
            lb.Items.Add(dgvTenSPNuoc);
            lb.Items.Add(dgvDonGiaNuoc);
            lb.Items.Add(dgvTTNuoc);
            lb.Items.Add(dgvMaLSPNuoc);

            My_DB.LoadData(qry, dataGridViewNuoc, lb);
        }
        public void GetDSSPAll()
        {
            string qry = "Select * From v_DanhSachSP ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaSPAll);
            lb.Items.Add(dgvTenSPAll);
            lb.Items.Add(dgvDonGiaAll);
            lb.Items.Add(dgvTTAll);
            lb.Items.Add(dgvMaLSPAll);

            My_DB.LoadData(qry, dataGridViewAll, lb);
        }
        private void dataGridViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSP.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmEditSP frm = new frmEditSP();

                frm.textBoxEditMaSP.Text = Convert.ToString(dataGridViewSP.CurrentRow.Cells["dgvMaSP"].Value);
                frm.textBoxEditTenSP.Text = Convert.ToString(dataGridViewSP.CurrentRow.Cells["dgvTenSP"].Value);
                frm.textBoxEditDonGia.Text = Convert.ToString(dataGridViewSP.CurrentRow.Cells["dgvDonGia"].Value);
                frm.comboBoxEditTT.Text = Convert.ToString(dataGridViewSP.CurrentRow.Cells["dgvTinhTrang"].Value);
                frm.textBoxEditMaLSP.Text = Convert.ToString(dataGridViewSP.CurrentRow.Cells["dgvMaLoaiSP"].Value);
                frm.ShowDialog();

                GetDSSP();
            }

            if (dataGridViewSP.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                string MaSP = Convert.ToString(dataGridViewSP.CurrentRow.Cells["dgvMaSP"].Value);
                string qry = "EXEC proc_xoaSanPham @MaSP";
                Hashtable ht = new Hashtable();

                ht.Add("@MaSP", MaSP);

                int rowsAffected = My_DB.SQL(qry, ht);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }

                GetDSSP();
            }
        }
        private void btnRefeshSP_Click(object sender, EventArgs e) { GetDSSP(); }
        public void btnAddSP_Click(object sender, EventArgs e)
        {
            frmAddSP frm = new frmAddSP();
            frm.ShowDialog();
            GetDSSP();
        }

        private void btnSearchSP_Click(object sender, EventArgs e)
        {
            try
            {
                string searchString = textBoxSearchSP.Text.Trim();
                string qry = "SELECT * FROM dbo.func_getProductListByString(@String)";

                using (SqlConnection sqlCon = new SqlConnection(My_DB.strCon))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@String", searchString);
                        sqlCon.Open();
                        DataTable dtResult = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtResult);
                        }
                        // Hiển thị kết quả trong DataGridView
                        dataGridViewSP.DataSource = dtResult;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện tìm kiếm: " + ex.Message);
            }
        }

        public void GetDSHD()
        {
            string qry = "Select * From v_HoaDonView";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvMaHD);
            lb.Items.Add(dgvNgayDH);
            lb.Items.Add(dgvMaKH);
            lb.Items.Add(dgvMaNV);
            lb.Items.Add(dgvTriGiaHD);

            My_DB.LoadData(qry, dataGridViewHD, lb);
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
            lb.Items.Add(dgvTT);

            My_DB.LoadData(qry, dgvKho, lb);
        }
        public void RefreshDataGridView()
        {
            GetDataKho();

        }
        public void GetDataPhieuChi()
        {
            string qry = "Select * FROM v_DonNhapHangView";

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

        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBatDau = dateTimePickerFrom.Value;
                DateTime ngayKetThuc = dateTimePickerTo.Value;
                string qry = "EXEC proc_TimKiemHoaDon @NgayBatDau, @NgayKetThuc";

                using (SqlConnection sqlCon = new SqlConnection(My_DB.strCon))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, sqlCon))
                    {
                        cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
                        cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = ngayKetThuc;
                        sqlCon.Open();
                        DataTable dtResult = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtResult);
                        }
                        // Hiển thị kết quả trong DataGridView
                        dataGridViewHD.DataSource = dtResult;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện tìm kiếm: " + ex.Message);
            }
        }

        private void btnRefeshHD_Click(object sender, EventArgs e) { GetDSHD(); }
      
        private void btnRefeshHome_Click(object sender, EventArgs e)
        {
            GetDSSPMy();
            GetDSSPPho();
            GetDSSPCom();
            GetDSSPBun();
            GetDSSPNuoc();
            GetDSSPAll();
        }

        private void btnCheckKH_Click(object sender, EventArgs e)
        {
            try
            {
                string searchSDT = textBoxSDT.Text.Trim();
                string qry = "SELECT dbo.SearchTenKHBySDT(@SDT)";

                using (SqlConnection sqlCon = new SqlConnection(My_DB.strCon))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@SDT", searchSDT);
                        sqlCon.Open();
                        // Sử dụng ExecuteScalar để lấy giá trị trả về từ hàm SQL
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value) // Khách hàng tồn tại
                        {
                            string tenKH = result.ToString();

                            MessageBox.Show($"Tên khách hàng có số điện thoại này là: {tenKH}");
                        }
                        else // Khách hàng không tồn tại
                        {
                            // Gọi form để điền thông tin khách hàng mới
                            frmAddKH frm = new frmAddKH();
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện tìm kiếm: " + ex.ToString());
            }
        }

        public void AddControls(Form f, Panel CenterPanel)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tabPhanCa")
            {
                PhanCa newForm = new PhanCa();
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;

                tabControl1.SelectedTab.Controls.Add(newForm);
                newForm.Show();
            }
            if (e.TabPage.Name == "tabNhanVien")
            {
                frmNhanVien newForm = new frmNhanVien();
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;

                tabControl1.SelectedTab.Controls.Add(newForm);
                newForm.Show();
            }
            if (e.TabPage.Name == "tabThemTk")
            {
               
            }


        }

        private void btnAddNL_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu frmThemNguyenLieu = new frmThemNguyenLieu();
            frmThemNguyenLieu.ShowDialog();
        }

        private void btnSearchNL_Click(object sender, EventArgs e)
        {
            string searchString = txtSearchKho.Text;
            using (SqlConnection connection = new SqlConnection(My_DB.strCon)) 
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GetDataPhieuChi();
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            GetDataKho();
        }

        private void btnDangKyTK_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan frm = new DangKyTaiKhoan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

       
    }
}