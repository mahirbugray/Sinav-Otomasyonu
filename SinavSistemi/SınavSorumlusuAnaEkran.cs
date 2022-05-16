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
    public partial class SınavSorumlusuAnaEkran : Form
    {
        public SınavSorumlusuAnaEkran()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgll =new SqlBaglantisi();

        public void load()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select soruID,soru,A,B,C,D,dogrucevap,ders From TBLSORUHAVUZU INNER JOIN TBLDERSLER ON TBLSORUHAVUZU.derslerID=TBLDERSLER.dersID", bgll.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void SınavSorumlusuAnaEkran_Load(object sender, EventArgs e)
        {
           /* DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLSORUHAVUZU",bgll.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/
           load();
        }



        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBLSORUHAVUZU (soru,A,B,C,D,dogrucevap,derslerID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgll.baglantı());
            cmd.Parameters.AddWithValue("@p1", sorutxt.Text);
            cmd.Parameters.AddWithValue("@p2", Atxtbox.Text);
            cmd.Parameters.AddWithValue("@p3", Btxtbox.Text);
            cmd.Parameters.AddWithValue("@p4", Ctxtbox.Text);
            cmd.Parameters.AddWithValue("@p5", Dtxtbox.Text);
            cmd.Parameters.AddWithValue("@p6", cevaptxt.Text);
            cmd.Parameters.AddWithValue("@p7", derstxt.Text);
            cmd.ExecuteNonQuery();
            bgll.baglantı().Close();
            MessageBox.Show("Soru eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            load();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Delete from TBLSORUHAVUZU where soruID=@p1", bgll.baglantı());
            cmd2.Parameters.AddWithValue("@p1", soruIDtxt.Text);
            cmd2.ExecuteNonQuery();
            bgll.baglantı().Close();    
            MessageBox.Show("Soru silindi","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            soruIDtxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sorutxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Atxtbox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Btxtbox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Ctxtbox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Dtxtbox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cevaptxt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            derstxt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update TBLSORUHAVUZU set soru=@p2,A=@p3,B=@p4,C=@p5,D=@p6,dogrucevap=@p7,derslerID=@p8 where soruID=@p1", bgll.baglantı());
            cmd3.Parameters.AddWithValue("@p1", soruIDtxt.Text);
            cmd3.Parameters.AddWithValue("@p2", sorutxt.Text);
            cmd3.Parameters.AddWithValue("@p3", Atxtbox.Text);
            cmd3.Parameters.AddWithValue("@p4", Btxtbox.Text);
            cmd3.Parameters.AddWithValue("@p5", Ctxtbox.Text);
            cmd3.Parameters.AddWithValue("@p6", Dtxtbox.Text);
            cmd3.Parameters.AddWithValue("@p7", cevaptxt.Text);
            cmd3.Parameters.AddWithValue("@p8", derstxt.Text);
            cmd3.ExecuteNonQuery();
            bgll.baglantı().Close();
            MessageBox.Show("Soru güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
