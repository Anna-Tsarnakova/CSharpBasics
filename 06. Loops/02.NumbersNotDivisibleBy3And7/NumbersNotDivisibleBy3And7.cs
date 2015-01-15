/* Problem 2. Numbers Not Divisible by 3 and 7
Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
Examples:
n	output
3	1 2
10	1 2 4 5 8 10
 */ 

using System;

class NumbersNotDivisibleBy3And7
{
    private static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int counter = 1;
        // with while loop
        while (counter <= n)
        {
            if (counter % 3 != 0 && counter % 7 != 0)
            {
                Console.Write("{0} ", counter);                
            }
            counter++;
        }
        Console.WriteLine();

        ////with do... while loop
        //do
        //{
        //    if (counter % 3 != 0 && counter % 7 != 0)
        //    {
        //        Console.Write("{0} ", counter);
        //    }
        //    counter++;
        //} while (counter < n);
        //Console.WriteLine();
        
        ////with for loop
        //for (int counter = 1; counter <= n; counter++)
        //{
        //    if (counter % 3 != 0 && counter % 7 != 0)
        //    {
        //        Console.Write("{0} ", counter);
        //    }
        //}
        //Console.WriteLine();
    }
}
