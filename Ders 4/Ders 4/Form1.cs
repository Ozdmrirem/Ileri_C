using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HJ161GJ\SQLEXPRESS;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select FilmAd, FilmPuan From Tbl_Filmler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Filmler"].Points.AddXY(oku[0].ToString(), oku[1]);
            }
            baglanti.Close();
        }
    }
}
