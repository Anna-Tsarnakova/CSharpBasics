﻿/* Problem 7. Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order. 
Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
Examples:
a	   b      c	     result
5	   1	  2	     5 2 1
-2	  -2	  1	     1 -2 -2
-2	  4	      3	     4 3 -2
0	  -2.5	  5	     5 0 -2.5
-1.1  -0.5	  -0.1	 -0.1 -0.5 -1.1
10	  20	  30     30 20 10
1	  1	      1	     1 1 1
*/ 

using System;
using System.Globalization;
using System.Threading;

class SortThreeNumbersNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a>= c)
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        else
        {
            if (a >= b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}

