using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_9 //geri deger dondurmeyen metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Metot1()
        {
            label1.Text = "07 Agustos 2025";
            label2.Text = "Sıcak bir yaz günü";
            label3.Text = "Peynir - Karpuz - Su";
            label4.Text = "Muğla / Fethiye / Göcek";
        }

        void Metot2()
        {
            label1.BackColor = Color.OrangeRed;
            label2.BackColor = Color.LightBlue;
            label3.BackColor = Color.DeepPink;
            label4.BackColor = Color.LightGoldenrodYellow;
        }

        void Metot3()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.DarkBlue;
            label3.ForeColor = Color.YellowGreen;
            label4.ForeColor = Color.Brown;
            this.Text = "C# Ders 9";
            MessageBox.Show("Metotlar çağrıldı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metot1();
            Metot2();
            Metot3();
        }
    }
}
