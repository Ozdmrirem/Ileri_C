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
using System.IO;

namespace Ders_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string baglantiadresi;
        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader oku = new StreamReader("C:\\Users\\irem\\adress.txt");
            string satir = oku.ReadLine();
            while ( satir != null ) 
            {
                baglantiadresi = satir;
                satir = oku.ReadLine();

            }

            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kisiler", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
