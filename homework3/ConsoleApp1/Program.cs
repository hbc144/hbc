using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
   public abstract class Shape//抽象图形类
    {
        public double area=0;
        public abstract double Area//抽象面积属性
        {
            get;set;
        }
        public abstract void Draw();     //绘制
    }

    public class Triangle : Shape    //三角形类
    {
        public double triSide1, triSide2, triSide3;
        public Triangle(double triSide1, double triSide2, double triSide3)       //构造三角形对象
        {
            double p = (triSide1 + triSide2 + triSide3) / 2;
            Area = System.Math.Sqrt(p * (p - triSide1) * (p - triSide2) * (p - triSide3));
        }
        public override double Area//重写面积属性
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw A Triangle.");
        }
    }
    public class Circle : Shape    //圆形类
    {
        public double radius;
        public Circle(double radius)
        {
            Area = System.Math.PI * radius * radius;
        }
        public override double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw A Circle.");
        }
    }

    public class Square : Shape      //正方形类
    {
        public double length;
        public Square(double length)
        {
            Area = length * length;
        }
        public override double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw A Square.");
        }
    }

    public class Rectangle : Shape      //矩形类
    {
        public double length1, length2;
        public Rectangle(double length1, double length2)
        {
            Area = length1 * length2;
        }
        public override double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw A Rectangle.");
        }
    }

    class Factory      //工厂类
    {
        public static Shape GetShape(int shapeType)
        {

            Shape shape = null;
            if (shapeType == 1)  //三角形
            {
                double TriSide1 = 0, TriSide2 = 0, TriSide3 = 0;
                System.Console.WriteLine("请依次输入三角形三边长:");
                TriSide1 = Convert.ToDouble(Console.ReadLine());
                TriSide2 = Convert.ToDouble(Console.ReadLine());
                TriSide3 = Convert.ToDouble(Console.ReadLine());
                shape = new Triangle(TriSide1, TriSide2, TriSide3);
            }
            else if (shapeType == 2)  //圆形
            {
                double radius = 0;
                System.Console.WriteLine("请输入圆的半径：");
                radius = Convert.ToDouble(Console.ReadLine());
                shape = new Circle(radius);
            }
            else if (shapeType == 3)  //矩形
            {
                double sideLen1 = 0, sideLen2 = 0;
                System.Console.WriteLine("\n请输入矩形的长和宽");
                sideLen1 = double.Parse(Console.ReadLine());
                sideLen2 = Convert.ToDouble(Console.ReadLine());
                shape = new Rectangle(sideLen1, sideLen2);

            }
            else if (shapeType == 4)  //正方形
            {
                double sideLen = 0;
                System.Console.WriteLine("\n请输入正方形的边长");
                sideLen = double.Parse(Console.ReadLine());
                shape = new Square(sideLen);

            }
            return shape;
        }
    }
    class Client
    {
        static void Main(string[] args)
        {
            Shape triangle1;    //创建一个三角形
            triangle1 = Factory.GetShape(1);
            System.Console.WriteLine(triangle1.Area);
            Shape circle1;
            circle1 = Factory.GetShape(2);    //圆形
            System.Console.WriteLine(circle1.Area);
            Shape rectangle1;
            rectangle1 = Factory.GetShape(3);//矩形
            System.Console.WriteLine(rectangle1.Area);
            Shape square1;
            square1 = Factory.GetShape(4);//正方形
            System.Console.WriteLine(square1.Area);
        }
    }
}
