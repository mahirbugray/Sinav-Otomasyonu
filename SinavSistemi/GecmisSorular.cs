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
        }
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
        
        
        //string tarih = DateTime.Now.ToString();
        private void Acvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 
            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Acvpbtn.Text == lbldogru.Text)
            {
                lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}",coz.AddDays(1));
                Acvpbtn.BackColor = Color.Green;
            }
            else if(Acvpbtn.Text != lbldogru.Text)
            {
                Acvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 7)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Acvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    Acvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Acvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }


        }

        private void Bcvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 
            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Bcvpbtn.Text == lbldogru.Text)
            {
               lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(1));
                Bcvpbtn.BackColor = Color.Green;

            }
            else if (Bcvpbtn.Text != lbldogru.Text)
            {
                Bcvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            seviye++;
            }

            if (seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 7)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Bcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    Bcvpbtn.BackColor = Color.Green;
                }
                else if (Acvpbtn.Text != lbldogru.Text)
                {
                    Bcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }
        }

        private void Ccvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            {

            
            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Ccvpbtn.Text == lbldogru.Text)
            {
                lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(1));
                Ccvpbtn.BackColor = Color.Green;
            }
            else if (Ccvpbtn.Text != lbldogru.Text)
            {
                Ccvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            seviye++;
            }

            if (seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 7)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Ccvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    Ccvpbtn.BackColor = Color.Green;
                }
                else if (Ccvpbtn.Text != lbldogru.Text)
                {
                    Ccvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }
        }

        private void Dcvpbtn_Click(object sender, EventArgs e)
        {
            if(seviye==2)
            { 
            DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
            if (Dcvpbtn.Text == lbldogru.Text)
            {
                
                lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(1));
                Dcvpbtn.BackColor = Color.Green;
            }
            else if (Dcvpbtn.Text != lbldogru.Text)
            {
                Dcvpbtn.BackColor = Color.Red;
            }
            btndevamet.Enabled = true;
            Acvpbtn.Enabled = false;
            Bcvpbtn.Enabled = false;
            Ccvpbtn.Enabled = false;
            Dcvpbtn.Enabled = false;
            seviye++;
            }

            if (seviye == 3)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(7));
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 4)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(30));
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 5)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(90));
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 6)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(180));
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }

            if (seviye == 7)
            {
                DateTime coz = DateTime.Parse(lblilkcozlmetrh.Text);
                if (Dcvpbtn.Text == lbldogru.Text)
                {
                    lblsoncozlmetrh.Text = String.Format("{0:dd/MM/yyyy}", coz.AddDays(365));
                    Dcvpbtn.BackColor = Color.Green;
                }
                else if (Dcvpbtn.Text != lbldogru.Text)
                {
                    Dcvpbtn.BackColor = Color.Red;
                }
                btndevamet.Enabled = true;
                Acvpbtn.Enabled = false;
                Bcvpbtn.Enabled = false;
                Ccvpbtn.Enabled = false;
                Dcvpbtn.Enabled = false;
                seviye++;
            }
        }

        
    }
}
