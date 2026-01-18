using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ders_1_Connection_String_Class
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HJ161GJ\SQLEXPRESS;Initial Catalog=DbLibrary;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
