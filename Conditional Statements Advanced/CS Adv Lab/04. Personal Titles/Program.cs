﻿using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender=="m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else 
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (gender=="f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else 
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}