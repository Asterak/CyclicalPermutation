using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclicalPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pattern(7)); // "1234567\n2345671\n3456712\n4567123\n5671234\n6712345\n7123456"
            Console.WriteLine(Pattern(4)); // "1234\n2341\n3412\n4123"
            Console.WriteLine(Pattern(1)); // 1

        }


        public static string Pattern(int n)
        {
            if (n <= 0) return "";
            
            List<string> resList = new List<string>();
            int i = 0;
            
            while (i < n)
            {
                resList.Add(string.Join("", Enumerable.Range(i+1, n - i)) + string.Join("", Enumerable.Range(1, i)));
                i++;
            }

            return string.Join("\n",resList);

            //return n < 1 ? "" : string.Join("\n", Enumerable.Range(1, n).Select(x => string.Join("", Enumerable.Range(x, n).Select(y => y > n ? y - n : y))));
        }

    }
}
