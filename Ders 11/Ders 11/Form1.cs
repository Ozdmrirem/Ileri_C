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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cars rb = new Cars();
            rb.renk = "Mavi";
            rb.fiyat = 200.000;
            rb.durum='s';
            rb.model = 2020;
            rb.hiz = 220;

            label1.Text=rb.renk;
            label2.Text=rb.fiyat.ToString();
            label3.Text=rb.durum.ToString();
            label4.Text=rb.model.ToString();
            label5.Text=rb.hiz.ToString();
            
            this.BackColor=Color.CadetBlue;

        }
    }
}
