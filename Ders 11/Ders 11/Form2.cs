using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cars rbl = new Cars();
            rbl.renk = "Kırmızı";
            rbl.fiyat = 250.000;
            rbl.durum = 'i';
            rbl.model = 2023;
            rbl.hiz = 240;

            label1.Text = rbl.renk;
            label2.Text = rbl.fiyat.ToString();
            label3.Text = rbl.durum.ToString();
            label4.Text = rbl.model.ToString();
            label5.Text = rbl.hiz.ToString();

            this.BackColor = Color.Bisque;
        }
    }
}
