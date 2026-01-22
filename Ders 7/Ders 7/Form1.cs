using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Kitap
        {
            public string kitapad;
            public string tur;
            public string yazar;
            public int sayfa;
            public double puan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            ktp.kitapad = "Beyaz Zambaklar Ülkesinde";
            ktp.yazar = "Grigory Petrov";
            ktp.sayfa = 220;
            ktp.tur = "Roman";
            ktp.puan = 7.8;

            label6.Text = ktp.kitapad;
            label7.Text = ktp.yazar;
            label8.Text = ktp.sayfa.ToString();
            label9.Text = ktp.tur;
            label10.Text = ktp.puan.ToString();

        }
    }
}
