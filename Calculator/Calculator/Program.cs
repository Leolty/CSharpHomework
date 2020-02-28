using System;


namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        { 
            Double num1 = 0;
            Double num2 = 0;
           
            Console.WriteLine("计算器\r");
            Console.WriteLine("\n");
            try
            {
                Console.WriteLine("请输入第一个数：");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("请输入第二个数：");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("输入错误");
                Console.Write("请按任意键退出计算");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("请输入运算符，支持+、-、*、/：");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine("结果: "+ num1+" + "+ num2+ "=" + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("结果: " + num1 + " - " + num2 + "=" + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("结果: " + num1 + " × " + num2 + "=" + (num1*num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("错误：除数不能为0");
                    }
                    else {
                        Console.WriteLine("结果: " + num1 + " ÷ " + num2 + "=" + (num1/num2));
                    }
                    break;
                default:
                    Console.WriteLine("错误：非法符号");
                    break;
            }

            Console.Write("请按任意键退出计算");
            Console.ReadKey();
        }
    }
}
