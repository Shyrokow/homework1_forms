using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_forms
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gstring = textBox1.Text;
            string Tstring = textBox2.Text;
            string V0string = textBox3.Text;
            string xstring = textBox4.Text;
            double g = Double.Parse(gstring);
            double T = Double.Parse(Tstring);
            double V0 = Double.Parse(V0string);
            double x = Double.Parse(xstring);
            double S, V, F;
            S = V0 * T + (Math.Pow(T, 2.0) * g) / 2;
            V = V0 + 0.5 * g * T;
            F = Math.Abs((Math.Sin(x - 3.1) / (2.4 * Math.PI)) + Math.Cos(Math.Pow(x, 2.0)));
            label5.Text = $"S = {S:F3}";
            label6.Text = $"V = {V:F3}";
            label7.Text = $"F = {F:F3}";
        }
    }
}
