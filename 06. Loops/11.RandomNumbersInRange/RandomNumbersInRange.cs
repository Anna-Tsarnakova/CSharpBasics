/* Problem 11.	Random Numbers in Given Range
Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 
Examples:
n	min	 max   random numbers
5	0	 1	   1 0 0 1 1
10	10	 15	   12 14 12 15 10 12 14 13 13 11
Note that the above output is just an example. Due to randomness, your program most probably will produce different results.
 */
using System;
using System.Globalization;

class RandomNumbersInRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        string result = String.Empty;
        for (int i = 0; i < n; i++)
        {
            int randomNumbers = randomGenerator.Next(min, max + 1); // creates numbers between min and max
            result += randomNumbers + " ";
        }
        Console.WriteLine(result);
    }
}
