﻿using System;

namespace ApptOverlap
{
    public static class Program
    {
        //Complete the 'isOverlapping' function below.
        public static bool isOverlapping(int appointment1Start, int appointment1End, int appointment2Start, int appointment2End)
        {
            ///INSERT YOUR CODE HERE
            return false;
        }

        ///Do not change Main method
        static void Main()
        {
            int appointment1Start = Convert.ToInt32(Console.ReadLine().Trim());
            int appointment1End = Convert.ToInt32(Console.ReadLine().Trim());
            int appointment2Start = Convert.ToInt32(Console.ReadLine().Trim());
            int appointment2End = Convert.ToInt32(Console.ReadLine().Trim());

            bool res = isOverlapping(appointment1Start, appointment1End, appointment2Start, appointment2End);

            Console.WriteLine((res ? 1 : 0));

        }
    }

}
