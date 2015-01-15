/* Problem 6. Longest Area in Array
Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), 
then find and print the longest sequence of equal elements (first its length, then its elements). 
If multiple sequences have the same maximal length, print the leftmost of them. 
Examples:
Input	Output         
6          3          
hi         ok
hi         ok
hello      ok
ok
ok
ok	

2
SoftUni    1
Hello	   SoftUni
4          4
hi         hi
hi         hi
hi	       hi
hi         hi 

5        2
wow     hi
hi      hi
hi
ok
ok	
*/

using System;

class LongestAreaInArray
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        string[] input = new string[n];
        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
        }

        int countEqualMembers = 1;
        int tempCounter = 0;
        string longestArea = input[0];
        for (int i = 1; i < n; i++)
        {
            if (input[i] == input[i - 1] && tempCounter == 0)
            {
                countEqualMembers++;
            }
            if (input[i] != input[i - 1])
            {
                tempCounter = 1;
            }
            if (input[i] == input[i - 1] && tempCounter > 0)
            {
                tempCounter++;
            }
            if (tempCounter > countEqualMembers)
            {
                longestArea = input[i];
                countEqualMembers = tempCounter;
                tempCounter = 0;
            }
        }
        //Output
        Console.WriteLine(countEqualMembers);
        for (int i = 0; i < countEqualMembers; i++)
        {
            Console.WriteLine(longestArea);
        }
    }
}
