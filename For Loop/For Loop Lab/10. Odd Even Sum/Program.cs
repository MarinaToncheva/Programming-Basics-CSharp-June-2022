﻿using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sumEven += value;
                }
                if (i%2!=0)
                {
                    sumOdd += value;
                }
            }
            if (sumEven==sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(sumEven)}");
            }
            else if (sumEven != sumOdd)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
            }
        }
    }
}
