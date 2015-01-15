/* Problem 18.* Trailing Zeroes in N!
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000. 
Examples:
n       	trailing zeroes of n!	 explaination
10	        2	                     3628800
20       	4	                     2432902008176640000
100000	    24999	                 think why
 */ 

using System;
using System.Numerics;

class TrailingZeroesInNFact
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        double trailingZeroes = 0;

        for (int i = 1; i < n; i++)
        {
            trailingZeroes += n / (long)(Math.Pow(5, i)); // n/5 + n/25 + n/125 + …
        }
        Console.WriteLine(trailingZeroes);  
    }
}

