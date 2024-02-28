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
    public partial class BangTinhLuong : Form
    {
        public BangTinhLuong()
        {
            InitializeComponent();
        }

        private void BangTinhLuong_Load(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_tinhLuongNV(@thang, @nam)",db.getConnection);
            cmd.Parameters.AddWithValue("@thang", int.Parse(DateTime.Today.ToString("MM")));
            cmd.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
            // Create a data adapter to fill a dataset with the results
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1_BangLuong.DataSource = ds.Tables[0];
            db.closeConnection();

        }
    }
}
