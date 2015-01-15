/* Problem 10. Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 
Examples:
  n   comments               
  1   0                      
  3   0 1 1                  
 10   0 1 1 2 3 5 8 13 21 34 
*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n =  ");
        uint n = uint.Parse(Console.ReadLine());
        uint a = 1;
        uint b = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write(b + " ");  //0 1 1 2 3 5...
            b = b + a;               //1 1 2 3 5 8...
            a = b - a;               //0 1 1 2 3 5...
        }
        Console.WriteLine();
    }
}