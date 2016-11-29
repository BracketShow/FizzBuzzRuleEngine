﻿using System;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine($"{i}");
            }
        }
    }
}
