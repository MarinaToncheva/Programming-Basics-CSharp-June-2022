﻿using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isValidNumber = (number >= 100 && number <= 200) || number == 0;
            if (!isValidNumber)
            {
                Console.WriteLine("invalid");
            }
        } 
    }
}