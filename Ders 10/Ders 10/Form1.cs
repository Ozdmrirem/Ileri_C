using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int toplam(int s1,int s2)
        {
            int s3= s1 + s2;
            return s3;
        }

        private int kupbul(int x)
        {
            int sonuc = x * x * x;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(5, 10).ToString();
            label2.Text = toplam(15, 25).ToString();
            label3.Text = toplam(50, 75).ToString();

            int sayi = Convert.ToInt16(textBox1.Text);
            label4.Text = kupbul(sayi).ToString();
        }
    }
}




