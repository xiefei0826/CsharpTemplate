using System;

namespace chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "foobar";
            string s2 = "foobar";
            if (s1.Equals(s2))
                Console.WriteLine("They are the same.");
            else
                Console.WriteLine("They are not the same.");
        }
    }
}
