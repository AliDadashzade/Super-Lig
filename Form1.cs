using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Lig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gal = 0, fen = 0, trab = 0, bes = 0, saygac = 1, a, b, c, d;
            Random eded = new Random();
            a = eded.Next(0, 4);
            b = eded.Next(0, 4);
            c = eded.Next(0, 4);
            d = eded.Next(0, 4);

            if (saygac == 1)
            {
                if (a > b) gal = gal + 3;
                else if (a < b) bes = bes + 3;
                else if (a == b)
                {
                    gal = gal + 1;
                    bes = bes + 1;
                }

                if (c > d) fen = fen + 3;
                else if (c < d) trab = trab + 3;
                else if (c == d)
                {
                    fen = fen + 1;
                    trab = trab + 1;
                }
                saygac++;
            }
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Text = c.ToString();
            textBox4.Text = d.ToString();
            textBox5.Text = gal.ToString();
            textBox6.Text = bes.ToString();
            textBox7.Text = fen.ToString();
            textBox8.Text = trab.ToString();

        }

        
    }
}
