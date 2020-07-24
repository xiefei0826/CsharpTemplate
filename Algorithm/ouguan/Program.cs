using System;

namespace ouguan
{
    class Program
    {
        private const int MaxN = 64;
        private static int[,] a = new int[MaxN + 1, MaxN + 1];

        /// <summary>
        /// 处理编号k开始的n个球队的日程
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        static void gamecal(int k, int n)
        {
            int i, j;
            if (n == 2)
            {
                a[k, 1] = k;//参赛球队编号
                a[k, 2] = k + 1;//对阵球队编号
                a[k + 1, 1] = k + 1;//参赛球队编号
                a[k + 1, 2] = k;//对阵球队编号
            }
            else
            {
                gamecal(k, n / 2);
                gamecal(k + n / 2, n / 2);
                for (i = k; i < k + n / 2; i++)//填充右上角
                {
                    for (j = n / 2 + 1; j <= n; j++)
                    {
                        a[i, j] = a[i + n / 2, j - n / 2];
                    }
                }
                for (i = k + n / 2; i < k + n; i++)//填充左下角
                {
                    for (j = n / 2 + 1; i <= n; j++)
                    {
                        a[i, j] = a[i - n / 2, j - n / 2];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int m = 4, i, j;
            Console.WriteLine($"参赛球队数：{m}");
            j = 2;
            for (i = 2; i < 8; i++)
            {
                j = j * 2;
                if (j == m) break;
            }
            if (i >= 8)
            {
                Console.WriteLine($"参赛球队数必须为2的整数次幂，并且不超过64");
                return;
            }
            gamecal(1, m);
            Console.WriteLine("编号 ");
            for (i = 2; i <= m; i++)
            {
                Console.WriteLine($"{i - 1}");
            }
        }
    }
}
