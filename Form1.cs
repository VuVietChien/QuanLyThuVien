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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection("Data Source=DESKTOP-VJNST16\\VVLONG;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            co.Open();
            String con = "insert into  login(name,username,password,email) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
            SqlCommand cm = new SqlCommand(con, co);
            cm.ExecuteNonQuery();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            DangNhap d = new DangNhap();
            d.Show();
            this.Close();
        }
    }
}
