using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a, b;
            Console.Write("Please input a double:");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.Write("Please input another double:");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.Write(a + " * " + b + " = " + a * b);
        }
    }
}
