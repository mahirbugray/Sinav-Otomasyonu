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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Admin için database den kullanıcı adı ve şifresini çekip kontrol ettiriyoruz dogru bilirse giriş yapabiliyor.
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBLADMIN where KullaniciAdi=@p1 and Sifre=@p2", baglan.baglantı());
            komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AdminAnaEkran ad = new AdminAnaEkran();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            baglan.baglantı().Close();
        }
    }
}
