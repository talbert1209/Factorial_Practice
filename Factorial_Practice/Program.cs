using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"The factorial of {i} is... {GetFactorial(i)}");
                Console.WriteLine($"The factorial of {i} is... {GetFactorialEasy(i)}");
            }

        }

        private static long GetFactorial(int n)
        {
            if (n == 0)
                return 1;
            var multiplyBy = GetFactorial(n - 1);
            return n * multiplyBy;
        }

        private static long GetFactorialEasy(int n)
        {
            long x = 1;
            long total = 1;
            while (x <= n)
            {
                total *= x;

                x++;
            }

            return total;
        }
    }
}
