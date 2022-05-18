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
    public partial class AdminAnaEkran : Form
    {
        public AdminAnaEkran()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        //lodaing fonksiyonu ile datagridviewe istedigimiz degerleri getiriyoruz
        public void loading()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select soruID,soru,A,B,C,D,dogrucevap,ders,sorudurumu From TBLSORUHAVUZU INNER JOIN TBLDERSLER ON TBLSORUHAVUZU.derslerID=TBLDERSLER.dersID where sorudurumu=0", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void AdminAnaEkran_Load(object sender, EventArgs e)
        {
            loading();
        }
        //sınav sorumlusunda yazılan sorular tabloda sorudurumu false olarak tutuluyor eger admin onaylarsa sorudurumu true olup artık sorularda gisteriliyor 
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBLSORUHAVUZU set sorudurumu=@p2,cozumseviyesi=@p3 where soruID=@p1 ", bgl.baglantı());
            cmd.Parameters.AddWithValue("@p1", txtid.Text);
            cmd.Parameters.AddWithValue("@p2", txtdurum.Text);
            cmd.Parameters.AddWithValue("@p3", txtseviye.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Soru eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loading();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
        }
    }
}
