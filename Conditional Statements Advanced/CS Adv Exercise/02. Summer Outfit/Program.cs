﻿using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {

            int degrees = int.Parse(Console.ReadLine()); //[10-42]
            string time = Console.ReadLine(); //Morning, Afternoon, Evening
            string outfit = "";
            string shoes = "";

            if (time=="Morning")
            {
                if (degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (time=="Afternoon")
            {
                if (degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else 
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else 
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
