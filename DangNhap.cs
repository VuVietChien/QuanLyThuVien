using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Data Source=DESKTOP-VJNST16\\VVLONG;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            sql.Open();
            string newc = "select username from login where username='" + textBox1.Text + "' and password='" + textBox3.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(newc, sql);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            if(dt.Rows.Count >= 1)
            {
                String set = textBox1.Text;
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("DANG NHAP THAT BAI!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKi r = new DangKi();
            r.Show();
            this.Hide();

        }
    }
}
