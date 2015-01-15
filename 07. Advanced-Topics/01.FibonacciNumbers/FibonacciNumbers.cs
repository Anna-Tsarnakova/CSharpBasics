/* Problem 1. Fibonacci Numbers
Define a method Fib(n) that calculates the nth Fibonacci number.
Examples:
n	Fib(n)
0	1
1	1
2	2
3	3
4	5
5	8
6	13
11	144
25	121393
*/
 
using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fib(n));  
    }

    static BigInteger Fib(int n)
    {
        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 0; i < n; i++)
        {
            b = a + b; 
            a = b - a; 
        }
        return b;
    }
}

