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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bagln = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //ogrenci burdan kayıt kapmak isterse bilgilerini yazıp bizde onları databasede kaydediyoruz ve ogrenci kaydı olusuyor
        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBLOGRENCI (Ad,Soyad,Sifre,KullaniciAdi) values (@p1,@p2,@p3,@p4)",bagln.baglantı());
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p4", txtkullaniciadi.Text);
            cmd.ExecuteNonQuery();
            bagln.baglantı().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
