using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[99];
            for(int i = 0; i < 99; i++)
            {
                num[i] = i + 2;
            }
            for(int n = 2; n < 101; n++)
            {
                for(int j = 0; j < 99; j++)
                {
                    if (num[j]!= 0)
                    {
                        if(num[j]%n==0 && num[j] / n != 1)
                        {
                            num[j] = 0;
                        }
                    }

                }
            }
            Console.WriteLine("2-100以内的素数有：");
            for(int k=0;k<100;k++)
            {
                if ( num[k]!= 0)
                {
                    Console.Write(num[k] + " ");
                }
            }
        }
    }
}
