﻿using System;
using System.ComponentModel;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                Console.Write("Enter an integer between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                bool v =<= 100;
                if (input >= 1 && v)
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Specify the series type: Even or Odd ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }

            }

            if (series == "Even")
            {
                Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

    