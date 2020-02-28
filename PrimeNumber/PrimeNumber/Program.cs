using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        //该函数判断一个数是否为素数
        static private bool IsPrimeNumber(int num)
        {
            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        //该函数输出素数因子
        static public void Factor(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                if(num%i == 0 && IsPrimeNumber(i))
                {
                    Console.WriteLine(i);
                }

            }
        }


        static void Main(string[] args)
        {
            int data;
            Console.WriteLine("请输入一个正整数：");
            try
            {
                data = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("输入错误，请输入整数");
                Console.ReadKey();
                return;
            }
            catch(OverflowException)
            {
                Console.WriteLine("输入错误，数据过大");
                Console.ReadKey();
                return;
            }

            if (data == 0 || data == 1)
            {
                Console.WriteLine(data + "没有素数因子");
            }
            else if(data < 0)
            {
                Console.WriteLine("请输入正整数");
            }
            else
            {
                Console.WriteLine("它的素数因子有：");
                Factor(data);
            }

        }
    }
}

