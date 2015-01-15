/* Problem 12.* Randomize the Numbers 1…N
Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 
Examples:
n	randomized numbers 1…n
3	2 1 3
10	3 4 8 2 6 7 9 1 10 5 
Note that the above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
*/
 
using System;

class RandomizeNumbersOneToN
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbersArray[i] = i + 1;
        }
        for (int i = 0; i < n; i++)
        {
            int indexOne = randomGenerator.Next(n);
            int indexTwo = randomGenerator.Next(n);
            int temp = numbersArray[indexOne];
            numbersArray[indexOne] = numbersArray[indexTwo];
            numbersArray[indexTwo] = temp;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", numbersArray[i]);
        }
        Console.WriteLine();
    }
}

