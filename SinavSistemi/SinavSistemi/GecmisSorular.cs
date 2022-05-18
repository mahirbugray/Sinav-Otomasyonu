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
    public partial class GecmisSorular : Form
    {
        public GecmisSorular()
        {
            InitializeComponent();
        }
        public string kullanıcıiddd;

        SqlBaglantisi bgl3 = new SqlBaglantisi();
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int seviye;
        private void btn1_Click(object sender, EventArgs e)
        {
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            btn1.Enabled = false;   
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            seviye = 2;
            lblseviye.Text =seviye.ToString();
            //SqlCommand kmttt = new SqlCommand("select * from TBLSORUHAVUZU WHERE cozumseviyesi='"+seviye+"'", bgl3.baglantı());
            //SqlDataReader oku = kmttt.ExecuteReader();
            //while (oku.Read())
            //{
            //    lblsoncozlmetrh.Text = (oku["soncozulmetarihi"].ToString());
                

            //}

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            seviye = 3;
            lblseviye.Text = seviye.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            seviye = 4;
            lblseviye.Text = seviye.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            seviye = 5;
            lblseviye.Text = seviye.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            seviye = 6;
            lblseviye.Text = seviye.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            seviye = 7;
            lblseviye.Text = seviye.ToString();
        }
        //seviyesine gore tutuldu seviye kacsa ordan soruyu getiriyoruz ve 6 SİGMA burda yapıldı 
        //hangi butona basılırsa ordan bilgiyi , seviyesini ve tarihini alıyor ona gore soru getiriryor eger dogru yaparsan seviye 3 ise mesela
        //sonraki cozulebilme tarihini 90 gun yani 3 ay sonrasına atıyor ve eger gun ile bugunku tarih bir degilse onu soruyu o gun gelene 
        //butona ne kadar basarsan bas soruyu getrimiyor
        private void btndevamet_Click(object sender, EventArgs e)
        {

            btndevamet.Enabled = false;
            Acvpbtn.Enabled = true;
            Bcvpbtn.Enabled = true;
            Ccvpbtn.Enabled = true;
            Dcvpbtn.Enabled = true;
            Acvpbtn.BackColor = Color.Gray;
            Bcvpbtn.BackColor = Color.Gray;
            Ccvpbtn.BackColor = Color.Gray;
            Dcvpbtn.BackColor = Color.Gray;
            btndevamet.Text = "BAŞLA";
            

            if (seviye == 2)
            {
                SqlCommand cmd = new SqlCommand("Select * from TBLSORUHAVUZU where cozumseviyesi='"+seviye+"'",bgl3.baglantı());
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    
                    lblID.Text = dr["soruID"].ToString();
                    textBox1.Text = (dr["soru"].ToString());
                    Acvpbtn.Text = (dr["A"].ToString());
                    Bcvpbtn.Text = (dr["B"].ToString());
                    Ccvpbtn.Text = (dr["C"].ToString());
                    Dcvpbtn.Text = (dr["D"].ToString());
                    lblilkcozlmetrh.Text = (dr["cozulmetarihi"].ToString());
                    lbldogru.Text = (dr["dogrucevap"].ToString()) ;
                }
                bgl3.baglantı().Close();
                
            }
            if (seviye == 3)
            {
                SqlCommand cmd = new SqlCommand("Select * from TBLSORUHAVUZU where cozumseviyesi='" + seviye + "'", bgl3.baglantı());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblID.Text = dr["soruID"].ToString();
                    textBox1.Text = (dr["soru"].ToString());
                    Acvpbtn.Text = (dr["A"].ToString());
                    Bcvpbtn.Text = (dr["B"].ToString());
                    Ccvpbtn.Text = (dr["C"].ToString());
                    Dcvpbtn.Text = (dr["D"].ToString());
                    lblilkcozlmetrh.Text = (dr["cozulmetarihi"].ToString());
                    lbldogru.Text = (dr["dogrucevap"].ToString());
                }
                bgl3.baglantı().Close();

            }
            if (seviye == 4)
            {
                SqlCommand cmd = new SqlCommand("Select * from TBLSORUHAVUZU where cozumseviyesi='" + seviye + "'", bgl3.baglantı());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblID.Text = dr["soruID"].ToString();
                    textBox1.Text = (dr["soru"].ToString());
                    Acvpbtn.Text = (dr["A"].ToString());
                    Bcvpbtn.Text = (dr["B"].ToString());
                    Ccvpbtn.Text = (dr["C"].ToString());
                    Dcvpbtn.Text = (dr["D"].ToString());
                    lblilkcozlmetrh.Text = (dr["cozulmetarihi"].ToString());
                    lbldogru.Text = (dr["dogrucevap"].ToString());
                }
                bgl3.baglantı().Close();

            }
            if (seviye == 5)
            {
                SqlCommand cmd = new SqlCommand("Select * from TBLSORUHAVUZU where cozumseviyesi='" + seviye + "'", bgl3.baglantı());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblID.Text = dr["soruID"].ToString();
                    textBox1.Text = (dr["soru"].ToString());
                    Acvpbtn.Text = (dr["A"].ToString());
                    Bcvpbtn.Text = (dr["B"].ToString());
                    Ccvpbtn.Text = (dr["C"].ToString());
                    Dcvpbtn.Text = (dr["D"].ToString());
                    lblilkcozlmetrh.Text = (dr["cozulmetarihi"].ToString());
                    lbldogru.Text = (dr["dogrucevap"].ToString());
                }
                bgl3.baglantı().Close();

            }
            if (seviye == 6)
            {
                SqlCommand cmd = new SqlCommand("Select * from TBLSORUHAVUZU where cozumseviyesi='" + seviye + "'", bgl3.baglantı());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblID.Text = dr["soruID"].ToString();
                    textBox1.Text = (dr["soru"].ToString());
                    Acvpbtn.Text = (dr["A"].ToString());
                    Bcvpbtn.Text = (dr["B"].ToString());
                    Ccvpbtn.Text = (dr["C"].ToString());
                    Dcvpbtn.Text = (dr["D"].ToString());
                    lblilkcozlmetrh.Text = (dr["cozulmetarihi"].ToString());
                    lbldogru.Text = (dr["dogrucevap"].ToString());
                }
                bgl3.baglantı().Close();

            }
            if (seviye == 7)
            {
                SqlCommand cmd = new SqlCommand("Select * from TBLSORUHAVUZU where cozumseviyesi='" + seviye + "'", bgl3.baglantı());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblID.Text = dr["soruID"].ToString();
                    textBox1.Text = (dr["soru"].ToString());
                    Acvpbtn.Text = (dr["A"].ToString());
                    Bcvpbtn.Text = (dr["B"].ToString());
                    Ccvpbtn.Text = (dr["C"].ToString());
                    Dcvpbtn.Text = (dr["D"].ToString());
                    lblilkcozlmetrh.Text = (dr["cozulmetarihi"].ToString());
                    lbldogru.Text = (dr["dogrucevap"].ToString());
                }
                bgl3.baglantı().Close();

            }




        }
        
        private void GecmisSorular_Load(object sender, EventArgs e)
        {
            lblogrenciid.Text = kullanıcıiddd;
            btndevamet.Enabled=false;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
        }
        
        //burda butonlar ile atamalar yapıldı mesela eger dogru bilirse yani eşitlik varsa seviyeyi bir arttırıp database update et
        //string tarih = DateTime.Now.ToString();
        private void Acvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 

            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Acvpbtn.Text == lbldogru.Text)
            {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}",coz.AddDays(7));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime( lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Green;
            }
            else if(Acvpbtn.Text != lbldogru.Text)
            {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2",seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();  
                    Acvpbtn.BackColor = Color.Red;

            }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if (seviye == 7)
            {
                SqlCommand cmd2 = new SqlCommand("Delete from TBLSORUHAVUZU where soruID=@p1", bgl3.baglantı());
                cmd2.Parameters.AddWithValue("@p1", lblID.Text);
                cmd2.ExecuteNonQuery();
                bgl3.baglantı().Close();
                MessageBox.Show("Tebrikler soruyu öğrendiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }

        private void Bcvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 
            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Bcvpbtn.Text == lbldogru.Text)
            {
               lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Green;

            }
            else if (Bcvpbtn.Text != lbldogru.Text)
            {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            
            }

            else if(seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if (seviye == 7)
            {
                SqlCommand cmd2 = new SqlCommand("Delete from TBLSORUHAVUZU where soruID=@p1", bgl3.baglantı());
                cmd2.Parameters.AddWithValue("@p1", lblID.Text);
                cmd2.ExecuteNonQuery();
                bgl3.baglantı().Close();
                MessageBox.Show("Tebrikler soruyu öğrendiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void Ccvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 

            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Ccvpbtn.Text == lbldogru.Text)
            {
                lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Green;
            }
            else if (Ccvpbtn.Text != lbldogru.Text)
            {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            
            }

            else if(seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if (seviye == 7)
            {
                SqlCommand cmd2 = new SqlCommand("Delete from TBLSORUHAVUZU where soruID=@p1", bgl3.baglantı());
                cmd2.Parameters.AddWithValue("@p1", lblID.Text);
                cmd2.ExecuteNonQuery();
                bgl3.baglantı().Close();
                MessageBox.Show("Tebrikler soruyu öğrendiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void Dcvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 
            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Dcvpbtn.Text == lbldogru.Text)
            {
                
                lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Green;
                    
                }
            else if (Dcvpbtn.Text != lbldogru.Text)
            {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            
            }

            else if(seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if(seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    seviye++;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set soncozulmetarihi=@p1 , cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p1", Convert.ToDateTime(lblsoncozlmetrh.Text));
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    seviye = 1;
                    SqlCommand cmdd = new SqlCommand("update TBLSORUHAVUZU set cozumseviyesi=@p2 where soruID='" + Convert.ToInt32(lblID.Text) + "'", bgl3.baglantı());
                    cmdd.Parameters.AddWithValue("@p2", seviye.ToString());
                    cmdd.ExecuteNonQuery();
                    bgl3.baglantı().Close();
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                
            }

            else if (seviye == 7)
            {
                SqlCommand cmd2 = new SqlCommand("Delete from TBLSORUHAVUZU where soruID=@p1", bgl3.baglantı());
                cmd2.Parameters.AddWithValue("@p1", lblID.Text);
                cmd2.ExecuteNonQuery();
                bgl3.baglantı().Close();
                MessageBox.Show("Tebrikler soruyu öğrendiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        
    }
}
