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
    public partial class SinavSorumlusuGiris : Form
    {
        public SinavSorumlusuGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Sınav sorumlusu için database den kullanıcı adı ve şifresini çekip kontrol ettiriyoruz dogru bilirse giriş yapabiliyor. 
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBLSINAVSORUMLUSU where KullaniciAdi=@p1 and Sifre=@p2", baglanti.baglantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SınavSorumlusuAnaEkran so = new SınavSorumlusuAnaEkran();
                so.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            baglanti.baglantı().Close();
        }
    }
}
