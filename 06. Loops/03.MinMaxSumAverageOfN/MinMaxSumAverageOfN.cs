/* Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
The output is like in the examples below. 
Examples:
input	output		    input     	output
3       min = 1          2          min = -1
2       max = 5          -1         max = 4
5       sum = 8          4          sum = 3
1	    avg = 2.67                  avg = 1.50
*/

using System;

class MinMaxSumAverageOfN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        int sum = 0;
        double average = 0;
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int allNumbers = numbers[i] = int.Parse(Console.ReadLine());
            if (minNumber > allNumbers)
            {
                minNumber = allNumbers;
            }
            if (maxNumber < allNumbers)
            {
                maxNumber = allNumbers;
            }
            sum += allNumbers;
            average = (double)sum/n;
        }
        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average); 
    }
}

