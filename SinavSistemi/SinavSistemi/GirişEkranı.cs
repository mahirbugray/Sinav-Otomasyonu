using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Burada butonla giriş yapma ekranına yönlendiriyoruz
        private void btnogrenci_Click(object sender, EventArgs e)
        {
            OgrenciGiris frm_OgrenciGiris = new OgrenciGiris();
            frm_OgrenciGiris.Show();
            this.Hide();
        }

        private void btngorevli_Click(object sender, EventArgs e)
        {
            SinavSorumlusuGiris frm_SinavSorumlusu = new SinavSorumlusuGiris();
            frm_SinavSorumlusu.Show();
            this.Hide();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminGiris frm_admin = new AdminGiris();
            frm_admin.Show();
            this.Hide();
        }

        
    }
}
