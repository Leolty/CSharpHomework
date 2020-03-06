using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public interface Shape
    {
        double GetArea();
        Boolean IsLegal();
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("输入不合法");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("输入不合法");
                }
                else
                {
                    height = value;
                }
            }
        }

        public Rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            if (IsLegal())
            {
                return width * height;
            }
            else
            {
                return -1;
            }
        }

        public bool IsLegal()
        {
            if(width>0&&height>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Square : Rectangle
    {
        double side;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public Square(double side) : base(side, side)
        {
            this.side = side;
        }
    }

    public class Triangle : Shape
    {
        double a, b, c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public Triangle(double a,double b , double c)
        {
                this.a = a;
                this.b = b;
                this.c = c;
        }
        public double GetArea()
        {
            double s = (a + b + c) / 2;
            double S = (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            if (IsLegal())
            {
                return S;
            }
            else
            {
                return -1;
            }    
        }

        public bool IsLegal()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(String shapeType,double a=0.0,double b=0.0,double c=0.0)
        {
            if (shapeType == null)
            {
                return null;
            }
            shapeType = shapeType.ToUpper();
            if ("TRIANGLE".Equals(shapeType))
            {
                return new Triangle(a,b,c);
            }
            else if ("RECTANGLE".Equals(shapeType))
            {
                return new Rectangle(a,b);
            }
            else if ("SQUARE".Equals(shapeType))
            {
                return new Square(a);
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[3] { "RECTANGLE", "SQUARE","TRIANGLE" };
            ShapeFactory shapeFactory = new ShapeFactory();
            Random ran = new Random();
            int rd = 0;
            int i = 0;
            double sumArea = 0.0;
            double a, b, c;
            while(i < 10)
            {
                rd = ran.Next(0,3);
                a = ran.Next();
                b = ran.Next();
                c = ran.Next();
                string shapeType = strArr[rd];
                Shape shape = shapeFactory.GetShape(shapeType, a, b, c);  
                if(shape.GetArea()!=-1)
                {
                    sumArea += shape.GetArea();
                    i++;
                    Console.Write(shapeType+"面积为");
                    Console.WriteLine(shape.GetArea());
                }
            }
            Console.WriteLine("总面积"+sumArea);
            Console.ReadKey();
        }
    }
}
