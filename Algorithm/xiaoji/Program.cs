using System;

namespace xiaoji
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;//定义三个变量，分别表示母鸡和小鸡的个数
            for (x = 0; x <= 20; x++)
            {
                for (y = 0; y <= 33; y++)
                {
                    z = 100 - x - y;
                    if (z % 3 == 0 && x * 5 + y * 3 + z / 3 == 100)
                    {
                        Console.WriteLine($"公鸡：{x},母鸡：{y},小鸡：{z}");
                    }
                }
            }
        }
    }
}
