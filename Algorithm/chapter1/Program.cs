using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            // TestCollection();

            // TestSwap();
            TestArrayListAddTime();
            TestCollectionAddTime();
            TestListAddTime();
        }

        private static void TestArrayListAddTime()
        {
            var time = new Timing();
            time.StartTime();
            var arrayList = new ArrayList();
            for (int i = 0; i < 100000; i++)
            {
                arrayList.Add(i);
            }
            time.StopTime();
            Console.WriteLine($"arrayList Result {time.Result().TotalMilliseconds}");
        }
        private static void TestCollectionAddTime()
        {
            var time = new Timing();
            time.StartTime();
            var arrayList = new Collection();
            for (int i = 0; i < 100000; i++)
            {
                arrayList.Add(i);
            }
            time.StopTime();
            Console.WriteLine($"arrayList Result {time.Result().TotalMilliseconds}");
        }
        private static void TestListAddTime()
        {
            var time = new Timing();
            time.StartTime();
            var arrayList = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                arrayList.Add(i);
            }
            time.StopTime();
            Console.WriteLine($"arrayList Result {time.Result().TotalMilliseconds}");
        }

        private static void TestSwap()
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine($"num1:{num1}");
            Console.WriteLine($"num2:{num2}");

            Swap<int>(ref num1, ref num2);

            Console.WriteLine($"num1:{num1}");
            Console.WriteLine($"num2:{num2}");

            string str1 = "Sam";
            string str2 = "Tom";

            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"str2:{str2}");

            Swap<string>(ref str1, ref str2);

            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"str2:{str2}");
        }

        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }

        private static void TestCollection()
        {
            Collection names = new Collection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymod");
            names.Add("Clayton");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Number of names:{names.Count()}");
        }
    }
}
