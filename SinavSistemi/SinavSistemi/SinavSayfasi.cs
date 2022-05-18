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
    public partial class SinavSayfasi : Form
    {
        public SinavSayfasi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string ogrenciID;
        int zaman = 61;
        int sayac = 0;
        int dogrusayisi=0;
        int yanlissayisi=0;
        int seviye = 1;
        string tarih = DateTime.Now.ToString();
        
        private void SinavSayfasi_Load(object sender, EventArgs e)
        {
            btndevamet.Text = "SINAVA BAŞLA";
            lblogrenciid.Text =ogrenciID.ToString();
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
        }

        public int soruseviyesi()

        {
            int seviyesoru=0;
            SqlCommand kmt=new SqlCommand("select cozumseviyesi from TBLSORUHAVUZU WHERE soruID=@P1",bgl.baglantı());
            kmt.Parameters.AddWithValue("@p1",Convert.ToInt32 (lblsoruid.Text));
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
               seviyesoru = Convert.ToInt32( oku[0]);
            }
            oku.Close();
            return seviyesoru;
        }
        
        private void btndevamet_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            zaman = 61;
            btndevamet.Text = "DEVAM ET";
            sayac++;
            lblsoru.Text = sayac.ToString();
            Acvpbtn.BackColor = Color.Gray;
            Bcvpbtn.BackColor = Color.Gray;
            Ccvpbtn.BackColor = Color.Gray;
            Dcvpbtn.BackColor = Color.Gray;

            btndevamet.Enabled = false;
            Acvpbtn.Enabled = true;
            Bcvpbtn.Enabled = true;
            Ccvpbtn.Enabled = true;
            Dcvpbtn.Enabled = true;
            //SqlCommand komut = new SqlCommand("Select *from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());
            //SqlCommand cmdd = new SqlCommand("insert into TBLSORUHAVUZU (cozumseviyesi)  values(@p1) ", bgl.baglantı());
            //SqlCommand komut = new SqlCommand("Select * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());
            //cmdd.Parameters.AddWithValue("@p1", lblseviye.Text);
            //cmdd.ExecuteNonQuery();


            if (sayac == 1)
            {

                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());


                }
                


                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='"+Convert.ToInt32(lblsoruid.Text)+"'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32( lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();

            }
            if (sayac == 2)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text)); ;
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 3)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 4)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 5)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 6)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 7)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 8)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 9)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }
                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            if (sayac == 10)
            {
                SqlCommand komut = new SqlCommand("Select TOP(1) * from TBLSORUHAVUZU order by NEWID() ", bgl.baglantı());

                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblsoruid.Text = (oku["soruID"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());
                    lblseviye.Text = (oku["cozumseviyesi"].ToString());

                }

                //SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                //komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(lblseviye.Text));
                //komutt.ExecuteNonQuery();
                bgl.baglantı().Close();


            }

            if (sayac == 11)
            {
                textBox1.Text = "";
                Acvpbtn.Text = "";
                Bcvpbtn.Text = "";
                Ccvpbtn.Text = "";
                Dcvpbtn.Text = "";

                lbldogrusayisi.Text = dogrusayisi.ToString();
                lblyanlissayisi.Text = yanlissayisi.ToString();
                timer1.Enabled = false;
                btndevamet.Enabled = false;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                //globale aldım asagıdaki veriyi
                //string tarih = DateTime.Now.ToString();
                lbltarih.Text = tarih;
                
                SqlCommand cmd = new SqlCommand("insert into TBLSONUCLAR (kullaniciID,dogrusayisi,yanlissayisi,solvedate) values (@p1,@p2,@p3,@p4)", bgl.baglantı());
                cmd.Parameters.AddWithValue("@p1", lblogrenciid.Text);
                cmd.Parameters.AddWithValue("@p2", lbldogrusayisi.Text);
                cmd.Parameters.AddWithValue("@p3", lblyanlissayisi.Text);
                cmd.Parameters.AddWithValue("@p4", Convert.ToDateTime(lbltarih.Text));
                cmd.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Sınavınız bitmiştir , Sınav sonucunuz listenize eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Acvpbtn_Click(object sender, EventArgs e)
        {
            if(Acvpbtn.Text ==lbldogrucvp.Text)
            {

                seviye =2;
                lblseviye.Text = seviye.ToString();
                lbltrh.Text = tarih;
                SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2,cozulmetarihi=@p3 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                komutt.Parameters.AddWithValue("@p2", soruseviyesi()+1);
                komutt.Parameters.AddWithValue("@p3",Convert.ToDateTime(lbltrh.Text));
                komutt.ExecuteNonQuery();
                //SqlCommand cmdd = new SqlCommand("insert into TBLSORUHAVUZU (cozumseviyesi) values (@p1)", bgl.baglantı());
                //cmdd.Parameters.AddWithValue("@p1", lblseviye.Text);
                //cmdd.ExecuteNonQuery();
                //bgl.baglantı().Close();
                bgl.baglantı().Close();
                dogrusayisi++;
                Acvpbtn.BackColor = Color.Green;
            }
            else if(Acvpbtn.Text !=lbldogrucvp.Text)
            {
                yanlissayisi++;
                Acvpbtn.BackColor= Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
        }

        private void Bcvpbtn_Click(object sender, EventArgs e)
        {
            if (Bcvpbtn.Text == lbldogrucvp.Text)
            {
                seviye =2;
                lblseviye.Text = seviye.ToString();
                lbltrh.Text = tarih;
                SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2,cozulmetarihi=@p3 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(soruseviyesi() + 1));
                komutt.Parameters.AddWithValue("@p3", Convert.ToDateTime(lbltrh.Text));
                komutt.ExecuteNonQuery();
                //SqlCommand cmdd = new SqlCommand("insert into TBLSORUHAVUZU (cozumseviyesi) values (@p1)", bgl.baglantı());
                //cmdd.Parameters.AddWithValue("@p1", lblseviye.Text);
                //cmdd.ExecuteNonQuery();
                //bgl.baglantı().Close();
                bgl.baglantı().Close();
                dogrusayisi++;
                Bcvpbtn.BackColor = Color.Green;
            }
            else if(Bcvpbtn.Text != lbldogrucvp.Text)
            {
                yanlissayisi++;
                Bcvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
        }

        private void Ccvpbtn_Click(object sender, EventArgs e)
        {
            if (Ccvpbtn.Text == lbldogrucvp.Text)
            {
                seviye =2;
                lblseviye.Text = seviye.ToString();
                lbltrh.Text = tarih;
                SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2,cozulmetarihi=@p3 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(soruseviyesi() + 1));
                komutt.Parameters.AddWithValue("@p3", Convert.ToDateTime(lbltrh.Text));
                komutt.ExecuteNonQuery();
                //SqlCommand cmdd = new SqlCommand("insert into TBLSORUHAVUZU (cozumseviyesi) values (@p1)", bgl.baglantı());
                //cmdd.Parameters.AddWithValue("@p1", lblseviye.Text);
                //cmdd.ExecuteNonQuery();
                //bgl.baglantı().Close();
                bgl.baglantı().Close();
                dogrusayisi++;
                Ccvpbtn.BackColor = Color.Green;
            }
            else if(Ccvpbtn.Text != lbldogrucvp.Text)
            {
                yanlissayisi++;
                Ccvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
        }

        private void Dcvpbtn_Click(object sender, EventArgs e)
        {
            if (Dcvpbtn.Text == lbldogrucvp.Text)
            {
                seviye =2;
                lblseviye.Text = seviye.ToString();
                lbltrh.Text =tarih;
                SqlCommand komutt = new SqlCommand("Update TBLSORUHAVUZU set cozumseviyesi=@p2,cozulmetarihi=@p3 where soruID='" + Convert.ToInt32(lblsoruid.Text) + "'", bgl.baglantı());
                komutt.Parameters.AddWithValue("@p2", Convert.ToInt32(soruseviyesi() + 1));
                komutt.Parameters.AddWithValue("@p3", Convert.ToDateTime(lbltrh.Text));
                komutt.ExecuteNonQuery();
                //SqlCommand cmdd = new SqlCommand("insert into TBLSORUHAVUZU (cozumseviyesi) values (@p1)", bgl.baglantı());
                //cmdd.Parameters.AddWithValue("@p1", lblseviye.Text);
                //cmdd.ExecuteNonQuery();
                //bgl.baglantı().Close();
                bgl.baglantı().Close();
                dogrusayisi++;
                Dcvpbtn.BackColor = Color.Green;
            }
            else if(Dcvpbtn.Text != lbldogrucvp.Text)
            {
                yanlissayisi++;
                Dcvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();
            if(zaman == 0)
            {
                timer1.Enabled = false;
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled=false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;    
            }
        }

        private void btnsnvbitir_Click(object sender, EventArgs e)
        {
            GecmisSorular frm = new GecmisSorular();
            frm.Show();
            frm.kullanıcıiddd = ogrenciID;
            this.Hide();
        }

        //private void btnsnvbitir_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = "";
        //    Acvpbtn.Text = "";
        //    Bcvpbtn.Text = "";
        //    Ccvpbtn.Text = "";
        //    Dcvpbtn.Text = "";

        //    lbldogrusayisi.Text = dogrusayisi.ToString();
        //    lblyanlissayisi.Text = yanlissayisi.ToString();
        //    timer1.Enabled = false;
        //    btndevamet.Enabled = false;
        //    Acvpbtn.Enabled = false;
        //    Bcvpbtn.Enabled = false;
        //    Ccvpbtn.Enabled = false;
        //    Dcvpbtn.Enabled = false;

        //    string tarih = DateTime.Now.ToString();
        //    lbltarih.Text = tarih;


        //    SqlCommand cmd = new SqlCommand("insert into TBLSONUCLAR (kullaniciID,dogrusayisi,yanlissayisi,solvedate) values (@p1,@p2,@p3,@p4)", bgl.baglantı());
        //    cmd.Parameters.AddWithValue("@p1", lblogrenciid.Text);
        //    cmd.Parameters.AddWithValue("@p2", lbldogrusayisi.Text);
        //    cmd.Parameters.AddWithValue("@p3", lblyanlissayisi.Text);
        //    cmd.Parameters.AddWithValue("@p4", Convert.ToDateTime(lbltarih.Text));
        //    cmd.ExecuteNonQuery();
        //    bgl.baglantı().Close();
        //    MessageBox.Show("Sınavınız bitmiştir , Sınav sonucunuz listenize eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}

/*
 while(sayac<10)
{
    SqlCommand komut = new SqlCommand("Select *from TBLSORUHAVUZU order by NEWID()", bgl.baglantı());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = (oku["soru"].ToString());
                    Acvpbtn.Text = (oku["A"].ToString());
                    Bcvpbtn.Text = (oku["B"].ToString());
                    Ccvpbtn.Text = (oku["C"].ToString());
                    Dcvpbtn.Text = (oku["D"].ToString());
                    lbldogrucvp.Text = (oku["dogrucevap"].ToString());

                }
                bgl.baglantı().Close();
                sayac++;
}
 
 
 */
