﻿using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            if (budget<=100)
            {
                if (season=="Summer")
                {
                    price = budget * 0.35;
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                else
                {
                    price = budget * 0.65;
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            else if (budget>100 && budget<=500)
            {
                if (season=="Summer")
                {
                    price = budget * 0.45;
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                else
                {
                    price = budget * 0.80;
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            else if (budget>500)
            {
                price = budget * 0.90;
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {price:f2}");
            }
        }
    }
}
