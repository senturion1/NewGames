using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriaVGC
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        public void danoGolpe() 
        {
            lblTotal.Text = "";

            Random rand = new Random();
            Random rand2 = new Random();
            double nivel = 5, Atk = 50, Def = 60, Power = 20, delta = 0, Stab = 2, Crit = Convert.ToDouble(rand2.Next(1, 4)), Efetive = 2, Addons = 1, dano = 0;

            //double Atk = 50;
            //double Def = 60;
            //double Power = 20;
            //double nivel = 5;
            //double Addons = 1;
            //double Stab = 2;
            double vlrRan = rand.Next(85, 100);
            double RandomVlr = Convert.ToDouble( vlrRan * 0.01);

            if (Crit != 4)
            {
                Crit = 1;
            }
            else
            {
                Crit = Atk * 0.4;
            }
            double calDelta = Stab * Efetive * Crit * Addons * RandomVlr;


             dano = ( ((2 * nivel + 10) / 50) * ((Atk / Def) * Power + 2)) * calDelta;


            lblTotal.Text = Convert.ToString(Math.Round(dano));
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            

            danoGolpe();

        }
    }
}
