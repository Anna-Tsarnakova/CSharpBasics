/* Problem 1. Numbers from 1 to N
Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 
Examples:
n	output
3	1 2 3
5	1 2 3 4 5
*/

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint counter = 1;
        while (counter <= n)
        {
            Console.Write("{0} ", counter);
            counter++;
        }
        Console.WriteLine();
    }
}
