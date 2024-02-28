using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQA
{
    internal class My_DB
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=THEBIN\THEBIN;Initial Catalog=QuanLyQuanAn;User Id=" + Global.username + ";Password=" + Global.password + ";");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        /*public static SqlConnection conAdmin = new SqlConnection(@"Data Source=THEBIN\THEBIN;Initial Catalog=QuanLyQuanAn;Integrated Security=True;");*/
        public static SqlConnection conAdmin = new SqlConnection(@"Data Source=THEBIN\THEBIN;Initial Catalog=QuanLyQuanAn;User Id=" + Global.username + ";Password=" + Global.password + ";");
        public SqlConnection getConnectionAdmin
        {
            get
            {
                return conAdmin;
            }
        }
        // open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void openConnectionAdmin()
        {
            if (conAdmin.State == ConnectionState.Closed)
            {
                conAdmin.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void closeConnectionAdmin()
        {
            if (conAdmin.State == ConnectionState.Open)
            {
                conAdmin.Close();
            }
        }
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            
            return res;
        }


      
        //Tao 2 bien cuc bo
        public static readonly string strCon = @"Data Source=THEBIN\THEBIN;Initial Catalog=QuanLyQuanAn;User Id=" + Global.username + ";Password=" + Global.password + ";";
        public static SqlConnection sqlCon = new SqlConnection(strCon);
    }
}
