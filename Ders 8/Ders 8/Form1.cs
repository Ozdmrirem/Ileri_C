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

        private void button1_Click(object sender, EventArgs e)
        {
            string baglantiadresi;
            StreamReader oku = new StreamReader("E:\\Adres.txt");
            string satir = oku.ReadLine();
            while ( satir != null ) 
                {
                     
                }
        }
    }
}
