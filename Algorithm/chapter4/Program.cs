using System;
using System.Collections.Generic;

namespace chapter4
{
    public class A
    {
        public int B { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
        static CArray GetArrar(int length)
        {
            var rnd = new Random(100);
            var arr = new CArray(length);
            for (int i = 0; i < length; i++)
            {
                arr.Insert(rnd.Next(0, length * 10));
            }
            return arr;
        }
    }
}
