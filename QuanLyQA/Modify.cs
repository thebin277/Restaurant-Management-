using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQA
{
    class Modify
    {
        SqlDataAdapter dataAdapter;// se truy xuat du lieu vao bang
        SqlCommand sqlCommand; //dung de truy van va cap nhat toi CSDL
        public Modify()
        {
        }
        //Bang tinh luong
        public DataSet bangTinhLuong()
        {
          
            DataSet dataSet = new DataSet();
            string query = "SELECT * FROM func_tinhLuongNV(@thang, @nam) ";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@thang", int.Parse(DateTime.Today.ToString("MM")));
                sqlCommand.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataSet);
                sqlConnection.Close();
            }

            return dataSet;
        }
        //Bang nhan vien
        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM v_LoadEmployee ";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            return dataTable;
        }
        public bool insert(NhanVien nhanVien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "EXEC proc_AddEmployee @manv, @ho, @ten, @ns, @gt,@dc, @sdt, @macv, @soca, @thuong, @ntd";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manv", SqlDbType.NChar, 10).Value = nhanVien.Manv;
                sqlCommand.Parameters.Add("@ho", SqlDbType.NVarChar, 10).Value = nhanVien.Ho;
                sqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar, 10).Value = nhanVien.Ten;
                sqlCommand.Parameters.Add("@ns", SqlDbType.Date).Value = nhanVien.Ns.ToShortDateString();
                sqlCommand.Parameters.Add("@gt", SqlDbType.NVarChar, 3).Value = nhanVien.Gt;
                sqlCommand.Parameters.Add("@dc", SqlDbType.NVarChar, 100).Value = nhanVien.Dc;
                sqlCommand.Parameters.Add("@sdt", SqlDbType.NVarChar, 11).Value = nhanVien.Sdt;
                sqlCommand.Parameters.Add("@macv", SqlDbType.NChar, 10).Value = nhanVien.Macv;
                sqlCommand.Parameters.Add("@soca", SqlDbType.Int).Value = nhanVien.Soca;
                sqlCommand.Parameters.Add("@thuong", SqlDbType.Int).Value = nhanVien.Thuong;
                sqlCommand.Parameters.Add("@ntd", SqlDbType.Date).Value = nhanVien.Ntd.ToShortDateString();
                sqlCommand.ExecuteNonQuery();// thuc thi lenh truy van

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                sqlConnection.Close();
                return false;
            }
           /* catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }*/
            return true;
        }

        public bool update(NhanVien nhanVien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update nhanvien set HoNV = @ho, TenNV = @ten, NgaySinh = @ns, GioiTinh = @gt, DiaChi = @dc, SDT = @sdt, MaCV = @macv, SoCa = @soca, Thuong = @thuong, NgayTD = @ntd Where MaNV = @manv";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manv", SqlDbType.NChar, 10).Value = nhanVien.Manv;
                sqlCommand.Parameters.Add("@ho", SqlDbType.NVarChar, 10).Value = nhanVien.Ho;
                sqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar, 10).Value = nhanVien.Ten;
                sqlCommand.Parameters.Add("@ns", SqlDbType.Date).Value = nhanVien.Ns.ToShortDateString();
                sqlCommand.Parameters.Add("@gt", SqlDbType.NVarChar, 3).Value = nhanVien.Gt;
                sqlCommand.Parameters.Add("@dc", SqlDbType.NVarChar, 100).Value = nhanVien.Dc;
                sqlCommand.Parameters.Add("@sdt", SqlDbType.NVarChar, 11).Value = nhanVien.Sdt;
                sqlCommand.Parameters.Add("@macv", SqlDbType.NChar, 10).Value = nhanVien.Macv;
                sqlCommand.Parameters.Add("@soca", SqlDbType.Int).Value = nhanVien.Soca;
                sqlCommand.Parameters.Add("@thuong", SqlDbType.Int).Value = nhanVien.Thuong;
                sqlCommand.Parameters.Add("@ntd", SqlDbType.Date).Value = nhanVien.Ntd.ToShortDateString();
                sqlCommand.ExecuteNonQuery();// thuc thi lenh truy van

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                sqlConnection.Close();
                return false;
            }
            /*catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }*/
            return true;
        }

        public bool delete(string manv)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "EXEC proc_DeleteEmployee @manv";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manv", SqlDbType.NChar, 10).Value = manv;
                sqlCommand.ExecuteNonQuery();// thuc thi lenh truy van

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                sqlConnection.Close();
                return false;
            }
            /* catch
             {
                 return false;
             }
             finally
             {
                 sqlConnection.Close();
             }*/
            return true;
        }
    }
}