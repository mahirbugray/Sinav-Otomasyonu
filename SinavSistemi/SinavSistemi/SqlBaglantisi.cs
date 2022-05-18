using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public class SqlBaglantisi
    {
        public SqlConnection baglantı()
        {
            SqlConnection baglan = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=SinavSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
        
    }
}
