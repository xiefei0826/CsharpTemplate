using System;

namespace jiecheng
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Factorial(15);
            Console.WriteLine($"15的阶乘是：{result}");
        }
        static long Factorial(long n)
        {
            if (n > 1)
                return n * Factorial(n - 1);
            else
            {
                return 1;
            }
        }
    }
}
