﻿using System;
using System.Collections.Generic;

namespace NeedleHaystack
{
    public static class Program
    {
        //Complete the 'findSequence' function below.
        public static int findSequence(List<string> haystack, List<string> needle)
        {
            ///INSERT YOUR CODE HERE
            return -1;
        }

        static void Main()
        {
            int haystackCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> haystack = new List<string>();

            for (int i = 0; i < haystackCount; i++)
            {
                string haystackItem = Console.ReadLine();
                haystack.Add(haystackItem);
            }

            int needleCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> needle = new List<string>();

            for (int i = 0; i < needleCount; i++)
            {
                string needleItem = Console.ReadLine();
                needle.Add(needleItem);
            }

            int res = findSequence(haystack, needle);

            Console.WriteLine(res);
        }

        

    }
}
