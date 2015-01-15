/* Problem 7. Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
Examples:
  numbers      sum | numbers	       sum | numbers             sum 
  1 2 3 4 5    15  | 10 10 10 10 10    50  | 1.5 3.14 8.2 -1 0   11.84 
*/
using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter 5 numbers, given in a single line, separated by space:");
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            double number = double.Parse(numbers[i]);
            sum = sum + number;
        }
        Console.WriteLine("sum = " + sum);
    }
}

