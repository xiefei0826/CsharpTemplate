using System;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers.GetValue(2));
            numbers.SetValue(44, index: 2);
            Console.WriteLine(numbers.GetValue(2));
        }
    }
}
