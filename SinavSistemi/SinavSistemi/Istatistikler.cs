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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string kullaniciiddd;
        private void Istatistikler_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select Count(*) From TBLSONUCLAR where kullaniciID='"+Convert.ToInt32( kullaniciiddd)+"'", bgl.baglantı());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblsınavsayisi.Text = dr1[0].ToString();
            }
            bgl.baglantı().Close();


            SqlCommand komut2 = new SqlCommand("Select Sum(dogrusayisi) From TBLSONUCLAR", bgl.baglantı());
            //count sayar , sum toplar.
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbldogrusayisi.Text = dr2[0].ToString();
            }
            bgl.baglantı().Close();

            SqlCommand komut3 = new SqlCommand("Select Sum(yanlissayisi) From TBLSONUCLAR", bgl.baglantı());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblyanlissayisi.Text = dr3[0].ToString();
            }
            bgl.baglantı().Close();

            SqlCommand komut4 = new SqlCommand("Select Avg(dogrusayisi) From TBLSONUCLAR", bgl.baglantı());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbldogruortalama.Text = dr4[0].ToString();
            }
            bgl.baglantı().Close();

            SqlCommand komut5 = new SqlCommand("Select Avg(yanlissayisi) From TBLSONUCLAR", bgl.baglantı());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblyanlisortalama.Text = dr5[0].ToString();
            }
            bgl.baglantı().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
