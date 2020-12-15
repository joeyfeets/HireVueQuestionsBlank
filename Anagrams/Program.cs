using System;
using System.Collections.Generic;

namespace Anagrams
{
    public static class Program
    {
        ///Complete the 'funWithAnagrams' method below.
        public static List<string> funWithAnagrams(List<string> s)
        {
            List<string> toRemove = new List<string>();

            ///INSERT YOUR CODE HERE

            return s;
        }

        ///Do not change Main method
        static void Main()
        {

            int sCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> s = new List<string>();

            for (int i = 0; i < sCount; i++)
            {
                string sItem = Console.ReadLine();
                s.Add(sItem);
            }

            List<string> result = funWithAnagrams(s);

            Console.WriteLine(String.Join("\n", result));
        }
    }

}
