using System;

namespace shuntui
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            long[] fib = new long[13];
            fib[0] = 1;
            fib[1] = 1;
            //顺推每个月的总数
            for (i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            //循环输出 每个月的总数
            for (i = 0; i < fib.Length; i++)
            {
                Console.WriteLine($"第{i}月兔子总数：{fib[i]}");
            }
        }
    }
}
