using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public abstract class Shape
    {
        public abstract double Area    //面积，抽象属性
        {
            get;
        }
        public abstract void Draw();    //绘制
        public abstract void Erase();    //消除

    }
    public class Triangle : Shape    //三角形类
    {
        private int TriSide1, TriSide2, TriSide3;
        public  double Area
        {
            get
            {

            }
        }
        public void Draw()
    }


    class Client
    {
        static void Main(string[] args)
        {
        }
    }
}
