﻿/* Problem 9. Sum of n Numbers
 Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 
Examples:
  numbers  sum | numbers   sum | numbers   sum 
  3         90 | 5         6.5 | 1          1 
  20           | 2             | 1            
  60           | -1            |               
  10           | -0.5          |               
               | 4             |               
               | 2             |               
*/
using System;
using System.Globalization;
using System.Threading;

class SumOfNumbersN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("sum = " + sum);
    }
}

