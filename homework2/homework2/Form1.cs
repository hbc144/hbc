using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string p="素数因子为： ";
            int a = int.Parse(s);
            for(int i=2;i<a;i++)
            {
                if (a % i == 0)
                {
                    p += i + " ";
                    a = a / i;
                }
                if (a % i == 0)
                {
                    i--;
                }
            }
            label2.Text = p+a;
        }
    }
}
