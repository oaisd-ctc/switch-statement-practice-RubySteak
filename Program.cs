﻿using System;


public class Program
{

    public static void Main(string[] args)
    {
         Console.WriteLine("Enter a number");
         int x = int.Parse(Console.ReadLine());

         if (x == 1)
         {
            Console.WriteLine("Your number is one");
         }
         else if (x == 2)
         {
            Console.WriteLine("Your number is two");
         }
         else if (x == 3)
         {
            Console.WriteLine("Your number is three");
         }
         else if (x == 4)
         {
            Console.WriteLine("Your number is four");
         }
         else if (x == 5)
         {
            Console.WriteLine("Your number is five");
         }
         else if (x == 6)
         {
            Console.WriteLine("Your number is six");
         }
         else if (x == 7)
         {
            Console.WriteLine("Your number is seven");
         }
         else if (x == 8)
         {
            Console.WriteLine("Your number is eight");
         }
         else if (x == 9)
         {
            Console.WriteLine("Your number is nine");
         }
         else if (x == 10)
         {
            Console.WriteLine("Your number is ten");
         }
         else if (x > 10)
         {
            Console.WriteLine("That number is not in range");
         }
    }

}