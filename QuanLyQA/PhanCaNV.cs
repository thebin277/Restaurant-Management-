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
    public partial class PhanCaNV : Form
    {
        public PhanCaNV()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string qry = "EXEC dbo.proc_PhanCa @maca, @manv, @dayOfWeek";
                Hashtable ht = new Hashtable();
                ht.Add("@maca", comboBoxMaCa.Text);
                ht.Add("@manv", textBoxMaNV.Text);
                ht.Add("@dayOfWeek", dateTimeNgayLam.Text);

                int result = My_DB.SQL(qry, ht);

                if (result > 0)
                {
                    MessageBox.Show("Phân ca thành công!");
                    textBoxMaNV.Focus();
                    dateTimeNgayLam.Focus();
                    comboBoxMaCa.Focus();
                }
                else
                {
                    MessageBox.Show("Phân ca thất bại!");
                }
            

        }
    }
        
}
