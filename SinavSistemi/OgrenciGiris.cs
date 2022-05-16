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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrenciKayit frm_OgrenciKayıt = new OgrenciKayit();
            frm_OgrenciKayıt.Show();
            this.Hide();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBLOGRENCI where KullaniciAdi=@p1 and Sifre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr[0].ToString();
                ogrenciAnaEkran og = new ogrenciAnaEkran();
                //kullanıcı adını ogrenci anaekrana gonderdik.
                og.kullaniiciadi = txtad.Text;
                og.kullaniciid = label2.Text;
                og.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bgl.baglantı().Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrSifreDegistir ogs = new OgrSifreDegistir();
            ogs.Show();
            this.Hide();
        }
    }
}
