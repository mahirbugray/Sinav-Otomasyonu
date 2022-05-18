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

namespace SinavSistemi
{
    public partial class ogrenciAnaEkran : Form
    {
        public ogrenciAnaEkran()
        {
            InitializeComponent();
        }
        SqlBaglantisi bagl = new SqlBaglantisi();
        public string kullaniiciadi;
        public string kullaniciid;
        private void ogrenciAnaEkran_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniiciadi.ToString();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLSONUCLAR where kullaniciID='" +kullaniciid.ToString()+"'",bagl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SinavSayfasi frm = new SinavSayfasi();
            frm.ogrenciID = kullaniciid.ToString();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
