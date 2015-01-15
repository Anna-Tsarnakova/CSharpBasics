/* Problem 8. Catalan Numbers
In combinatorics, the Catalan numbers are calculated by a formula.
Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
n	Catalan(n)
0	1
5	42
10	16796
15	9694845
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger nPlusOneFact = 1;
        BigInteger nMultTwoFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            nPlusOneFact *= i;
        }
        for (int i = 1; i <= 2 * n; i++)
        {
            nMultTwoFact *= i;
        }

        Console.WriteLine(nMultTwoFact / (nPlusOneFact * nFact));
    }
}

