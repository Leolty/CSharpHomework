using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编写面向对象程序实现长方形、正方形、三角形等形状的类。
//每个形状类都能计算面积、判断形状是否合法。 
//请尝试合理使用接口/抽象类、属性来实现。

//随机创建10个形状对象，计算这些对象的面积之和。 
//尝试使用简单工厂设计模式来创建对象。

namespace Shape
{

    public abstract class Shape
    {
        public abstract double getArea();
        public abstract void showArea();
    }

    interface needCheck
    {
        bool check();
    }

    public class Rectangle : Shape, needCheck
    {
        double width;
        double length;


        public Rectangle(double length, double width)
        {
            this.width = width;
            this.length = length;
            if (!check())
            {
                Console.WriteLine("Warning: Side length cannot be less than 0 ");
            }
        }

        public bool check()
        {
            if (width > 0 && length > 0)
            {
                return true;
            }
            else
                return false;
        }

        public override double getArea()
        {
            if (check())
            {
                return width * length;
            }
            else
            {
                return 0;
            }
        }


        public override void showArea()
        {
            if (getArea() != 0)
            {
                Console.WriteLine("Rectangle's area:" + getArea());
            }
            else
            {
                Console.WriteLine("Warning: illegal rectangle's area cannot be calculated");
                return;
            }
        }

    }

    public class Square : Shape, needCheck
    {
        double side;

        public Square(double side)
        {
            this.side = side;
            if (!check())
            {
                Console.WriteLine("Warning: Side length cannot be less than 0");
            }
        }

        public bool check()
        {
            if (side > 0)
            {
                return true;
            }
            else
                return false;
        }

        public override double getArea()
        {
            if (check())
            {
                return side * side;
            }
            else
            {
                return 0;
            }
        }

        public override void showArea()
        {
            if (getArea() != 0)
            {
                Console.WriteLine("Square's area:" + getArea());
            }
            else
            {
                Console.WriteLine("Warning: illegal square's area cannot be calculated");
                return;
            }
        }
    }
    public class Triangle : Shape, needCheck
    {
        double x;
        double y;
        double z;

        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            if(!(x > 0 && y > 0 && z > 0))
            {
                Console.WriteLine("Warning: Side length can not be less than 0");
            }

        }

        public bool check()
        {

            if (x > 0 && y > 0 && z > 0 && x + y > z && x + z > y && y + z > x)
            {
                return true;
            }
            else
                return false;
        }

        public override double getArea()
        {
            if (check())
            {
                double p = (x + y + z) / 2;
                return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            }
            else
            {
                return 0;
            }
        }

        public override void showArea()
        {
            if (getArea() != 0)
            {
                Console.WriteLine("Triangle's area:" + getArea());
            }
            else
            {
                Console.WriteLine("Warning: illegal triangle's area cannot be calculated");
                return;
            }
        }

        public class ShapeFactory
        {
            public Shape GetShape(String shapetype, double x = 0, double y = 0, double z = 0)
            {
                if (shapetype == null)
                {
                    return null;
                }

                shapetype = shapetype.ToLower();
                switch (shapetype)
                {
                    case "rectangle":
                        return new Rectangle(x, y);

                    case "square":
                        return new Square(x);

                    case "triangle":
                        return new Triangle(x, y, z);

                    default:
                        return null;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rec1 = new Rectangle(7.2, 8.7);
                rec1.showArea();

                Rectangle rec2 = new Rectangle(-7.2, 8.7);
                rec2.showArea();

                Square squ1 = new Square(5);
                squ1.showArea();

                Square squ2 = new Square(0);
                squ2.showArea();

                Triangle tri1 = new Triangle(6, 6, 6);

                tri1.showArea();
                Triangle tri2 = new Triangle(3, 5, 9);

                tri2.showArea();

                Triangle tri3 = new Triangle(-1, 9, 9);
                tri3.showArea();


                Console.WriteLine();
                Console.WriteLine("————————————————————————————————");
                Console.WriteLine();

                String[] type = new string[3] { "rectangle", "square", "triangle" };
                ShapeFactory shapeFactory = new ShapeFactory();
                Random ran = new Random();
                int i = 0;
                int rd = 0;
                double x = 0;
                double y = 0;
                double z = 0;
                double sumArea = 0;
                while (i < 10)
                {
                    rd = ran.Next(0, 3);
                    x = 100 * ran.NextDouble();//Avoid overflow
                    y = 100 * ran.NextDouble();
                    z = 100 * ran.NextDouble();
                    string shapetype = type[rd];
                    Shape shape = shapeFactory.GetShape(shapetype, x, y, z);
                    if (shape.getArea() != 0)
                    {
                        sumArea += shape.getArea();
                        i++;
                        Console.WriteLine("Shape"+i+": "+shapetype + "  Area：" + shape.getArea());
                    }
                }
                Console.WriteLine("Summarized Area: " + sumArea);               
            }
        }       
    }
}
