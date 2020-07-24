using System;

namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ShowArrayInsert();
            // ShowRandomInsert();
            // ShowBubbleSort();
            ShowSelectionSort();
            // ShowInsertionSort();
        }

        private static void ShowArrayInsert()
        {
            var nums = new CArray(50);

            for (int i = 0; i < 50; i++)
            {
                nums.Insert(i);
            }
            nums.DisplayElements();
        }
        private static void ShowRandomInsert()
        {
            var nums = new CArray(10);
            var rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                nums.Insert(rnd.Next(0, 100));
            }
            nums.DisplayElements();
        }
        private static void ShowBubbleSort()
        {
            var nums = new CArray(10);
            var rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                nums.Insert(rnd.Next(0, 100));
            }
            nums.DisplayElements();
            Console.WriteLine("-----------");
            nums.BubbleSort();
            Console.WriteLine("-----------");
            nums.DisplayElements();
        }
        private static void ShowSelectionSort()
        {
            var nums = new CArray(10);
            var rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                nums.Insert(rnd.Next(0, 100));
            }
            nums.DisplayElements();
            Console.WriteLine("-----------");
            nums.SelectionSort();
            Console.WriteLine("-----------");
            nums.DisplayElements();
        }
        private static void ShowInsertionSort()
        {
            var nums = new CArray(10);
            var rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                nums.Insert(rnd.Next(0, 100));
            }
            nums.DisplayElements();
            Console.WriteLine("-----------");
            nums.InsertionSort();
            Console.WriteLine("-----------");
            nums.DisplayElements();
        }

    }
}
