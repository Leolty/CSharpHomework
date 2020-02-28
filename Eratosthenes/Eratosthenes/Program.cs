using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
    class Program
    {
        static void PrimeNumber()
        {
            bool[] isPrime = new bool[101];

            //0和1都不是质数
            isPrime[1] = isPrime[0] = false;

            //初始化数据
            for (int i = 2; i <= 100; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j*j<=100 ; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int i = 0; i <= 100; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2-100内的所有素数有：");
            PrimeNumber();
        }
    }
}
