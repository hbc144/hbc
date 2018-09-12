using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            double a = Double.Parse(s1);
            string s2 = textBox2.Text;
            double b = Double.Parse(s2);
            label1.Text=a+" * "+b+" = "+a*b;
        }

        
    }
}
