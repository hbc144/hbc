using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8]{ 15, 21, 22, 35, 66, 71, 90, 16};
            int max = array[0];
            for(int i = 1; i < 8; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine("最大值是： " + max);
            int min = array[0];
            for(int i = 1; i < 8; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine("最小值是： " + min);
            int add = 0;
            for(int i = 0; i < 8; i++)
            {
                add += array[i];
            }
            Console.WriteLine("和为： " + add);
            Console.WriteLine("平均值为： " + add / 8);

            





        }
    }
}
