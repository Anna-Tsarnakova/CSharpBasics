/* Problem 5. Sorting Numbers
Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
Examples:
Input	Output
5       -3
3       0
-3      2
2       3
122     122
0	

3       0
0       0
1       1
0	
*/

using System;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Array.Sort(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

