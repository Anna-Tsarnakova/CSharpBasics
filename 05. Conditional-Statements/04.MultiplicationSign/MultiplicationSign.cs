﻿/* Problem 4. Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
Use a sequence of if operators. 
Examples:
a	 b	    c	   result
5	 2	    2	   +
-2	 -2	    1	   +
-2	 4	    3	   -
0	 -2.5   4	   0
-1	 -0.5   -5.1   -
 */ 

using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
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

        if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) || (c < 0 && b > 0 && a > 0) || (a < 0 && b < 0 && c < 0))
        {
            Console.WriteLine("-");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else Console.WriteLine("+");
    }
}

