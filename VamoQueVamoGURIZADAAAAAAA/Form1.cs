using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VamoQueVamoGURIZADAAAAAAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float N1 = float.Parse(textBox1.Text);
            float N2 = float.Parse(textBox2.Text);
            float N3 = float.Parse(textBox3.Text);
            float Maior;
            float Menor;
            float Menor2;


            if (N1 > N2)
            {
                Maior = N1;
                Menor = N2;

            }
            else
            {
                Maior = N2;
                Menor = N1;
            }
            if (Maior > N3)
            {
                Menor2 = N3;
            }
            else
            {
                Menor2 = Maior;
            }
            if (N1 != N2 && N1 != N3 && N3 != N2)
            { 
               textBox4.Clear();
               Maior = Menor + Menor2;
               textBox4.Text = Maior.ToString();
               textBox1.Clear();
               textBox2.Clear();
               textBox3.Clear();
               label5.Text = "";
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear(); textBox4.Clear();
                label5.Text = "NÃO DIGITE VALORES IGUAIS...";

            }
        }
    }
}
