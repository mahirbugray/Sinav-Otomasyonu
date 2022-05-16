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
    public partial class OgrSifreDegistir : Form
    {
        public OgrSifreDegistir()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Update TBLOGRENCI set Sifre=@p1 where KullaniciAdi=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.Parameters.AddWithValue("@p1", txtsifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Şifre Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglantı().Close();
            Application.Exit();
        }

        
    }
}
