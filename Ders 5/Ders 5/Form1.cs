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

namespace Ders_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HJ161GJ\SQLEXPRESS;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text=openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_filmler (FilmAd,FilmTur,FilmPuan,FilmKategori,FilmResim) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", txtTur.Text);
            komut.Parameters.AddWithValue("@p3", float.Parse(txtPuan.Text));
            komut.Parameters.AddWithValue("@p4", txtKategori.Text);
            komut.Parameters.AddWithValue("@p5", txtResim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_FilmArsivDataSet.Tbl_Filmler' table. You can move, or remove it, as needed.
            this.tbl_FilmlerTableAdapter.Fill(this.dbo_FilmArsivDataSet.Tbl_Filmler);

        }
    }
}
