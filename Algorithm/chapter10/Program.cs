using System;

namespace chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[13];
            string name;
            string[] someNames = new string[] { "David", "Jennifer", "Donnie", "Mayo", "Raymond", "Bernica", "Mike", "Clayton", "Beata", "Michael" };
            int hashVal;
            for (int i = 0; i < 10; i++)
            {
                name = someNames[i];
                // hashVal = SimpleHash(name, names);
                hashVal = BetterHash(name, names);
                names[hashVal] = name;
            }
            ShowDistrib(names);
        }
        static int SimpleHash(string s, string[] arr)
        {
            int tot = 0;
            char[] cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
            {
                tot += (int)cname[i];
            }
            return tot % arr.GetUpperBound(0);
        }
        static void ShowDistrib(string[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] != null)
                    Console.WriteLine(i + " " + arr[i]);
            }
        }
        static int BetterHash(string s, string[] arr)
        {
            long tot = 0;
            char[] cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
            {
                tot += 37 * tot + (int)cname[i];
            }
            tot = tot % arr.GetUpperBound(0);
            if (tot < 0)
                tot += arr.GetUpperBound(0);
            return (int)tot;
        }
        static bool InHash(string s, string[] arr)
        {
            int havl = BetterHash(s, arr);
            return arr[havl] == s;
        }
    }
}
