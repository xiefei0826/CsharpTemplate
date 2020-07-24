using System;
using System.Collections;
using System.Text;

namespace chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPrimes();
            // ShowBitArray();
            // ChangeBitArrayOrder();
        }
        private static void ChangeBitArrayOrder()
        {
            int bits;
            string[] binNumber = new string[8];
            int binary;
            byte[] ByteSet = new byte[] { 1, 2, 3, 4, 5 };
            BitArray BitSet = new BitArray(ByteSet);
            bits = 0;
            binary = 7;
            for (int i = 0; i <= BitSet.Count - 1; i++)
            {
                if (BitSet.Get(i))
                    binNumber[binary] = "1";
                else
                    binNumber[binary] = "0";
                bits++;
                binary--;
                if ((bits % 8) == 0)
                {
                    binary = 7;
                    bits = 0;
                    for (int ji = 0; ji <= 7; ji++)
                    {
                        Console.Write(binNumber[ji]);
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void ShowBitArray()
        {
            BitArray bitset1 = new BitArray(32, true);
            byte[] byteSet = new byte[] { 1, 2, 3, 4, 5 };
            BitArray bitSet = new BitArray(byteSet);
            for (int bits = 0; bits <= bitSet.Count - 1; bits++)
            {
                Console.Write(bitSet.Get(bits) + " ");
            }
        }

        private static void GetPrimes()
        {
            int size = 100;
            CArray primes = new CArray(size);
            for (int i = 0; i < size; i++)
            {
                primes.Insert(1);
            }
            primes.GenPrimes();
            primes.ShowPrimes();
        }
        public static void BuildSieve(BitArray bits)
        {
            string primes = "";
            for (int i = 0; i <= bits.Count - 1; i++)
                bits.Set(i, true);
            int lastBit = Int32.Parse(Math.Sqrt(bits.Count).ToString());
            for (int i = 2; i <= lastBit - 1; i++)
                if (bits.Get(i))
                    for (int j = 2 * i; j <= bits.Count - 1; j++)
                        bits.Set(j, false);
            int counter = 0;
            for (int i = 1; i <= bits.Count - 1; i++)
                if (bits.Get(i))
                {
                    primes += i.ToString();
                    counter++;
                    if ((counter % 7) == 0)
                        primes += "\n";
                    else
                        primes += "\n";
                }
        }
    }
}
