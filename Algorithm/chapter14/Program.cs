using System;

namespace chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 19;
            CArray theArray = new CArray(SIZE);
            Random random = new Random(100);
            for (int index = 0; index < SIZE; index++)
            {
                theArray.Insert(random.Next(100) + 1);
            }
            Console.WriteLine();
            theArray.DisplayElements();
            Console.WriteLine();
            theArray.MergeSort();
            theArray.DisplayElements();
        }
    }
}
