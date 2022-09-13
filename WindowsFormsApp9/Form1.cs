using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x = 0.36;
        double b = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double c =Convert.ToDouble(textBox1.Text);
            double a = x + 0.52 * b;
            b = a * Math.Pow(x, 2) + 1;
            double y = Math.Sqrt(Math.Pow(x, 3) + a * Math.Pow(x, 2)) + c;
            label2.Text = Math.Round( y,2).ToString();
            

        }
    }
}
