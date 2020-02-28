using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static int Minimum(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("空数组异常");
            }
            int min = 0;
            foreach(int x in array)
            {
                if(min >= x)
                {
                    min = x;
                }
            }
            return min;

        }

        static int Maximum(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("空数组异常");
            }
            int max = 0;
            foreach (int x in array)
            {
                if (max <= x)
                {
                    max = x;
                }
            }
            return max;
        }

        static int Sum(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("空数组异常");
            }
            int sum = 0;
            foreach (int x in array)
            {
                sum += x;
            }
            return sum;
        }

        static double Average(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("空数组异常");
            }
            double average;
            int sum;
            sum = Sum(array);
            average = sum / array.Length;
            return average;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 9, -3, 20, 67, -45, 32, 17, 0, 2 };
            int max, min,sum;
            double average;
            min = Minimum(array);
            max = Maximum(array);
            sum = Sum(array);
            average = Average(array);
            Console.WriteLine("数组最小值为：" + min);
            Console.WriteLine("数组最大值为：" + max);
            Console.WriteLine("数组所有值的和为：" + sum);
            Console.WriteLine("数组所有数的平均值为：" + average);
        }
    }
}
