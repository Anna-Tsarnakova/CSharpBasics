/* Problem 6. Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
Examples:
n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/

using System;
using System.Numerics;


class NFactDividedByNfact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        if (k <= 1 || k >= n || k >= 100 || n <= 1 || n >= 100)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    kFactorial *= i;
                }
                nFactorial *= i;
            }
            Console.WriteLine(nFactorial / kFactorial);
        }
    }
}

