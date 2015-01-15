/* Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even. Examples:
 n	Odd?
 3	true
 2	false
-2	false
-1	true
 0	false
*/

using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isOdd;
        if (n % 2 == 0) //n is even number
        {
            isOdd = false;
        }
        else //n is odd number
        {
            isOdd = true; 
        }
        Console.WriteLine("Odd? {0}", isOdd);
    }
}
