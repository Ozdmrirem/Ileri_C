using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HJ161GJ\SQLEXPRESS;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True;Encrypt=False");


        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            tbxResim.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Filmler (FilmAd,FilmTur, FilmPuan,FilmKategori,FilmResim) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", tbxFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", tbxTur.Text);
            komut.Parameters.AddWithValue("@p3", float.Parse(tbxPuan.Text));
            komut.Parameters.AddWithValue("@p4", tbxKategori.Text);
            komut.Parameters.AddWithValue("@p5", tbxResim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close(); 
            MessageBox.Show("Kayıt Eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_FilmArsivDataSet.Tbl_Filmler' table. You can move, or remove it, as needed.
            this.tbl_FilmlerTableAdapter.Fill(this.dbo_FilmArsivDataSet.Tbl_Filmler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxFilmId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbxFilmAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbxPuan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbxKategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
    }
}
