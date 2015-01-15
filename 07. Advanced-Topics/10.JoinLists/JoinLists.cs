/* Problem 10. Join Lists
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, 
and all numbers from the second list, without repeating numbers, and arranged in increasing order. 
The input and output lists are given as integers, separated by a space, each list at a separate line. 
Examples:
Input	              Output
20 40 10 10 30 80
25 20 40 30 10	      10 20 25 30 40 80
5 4 3 2 1
6 3 2	              1 2 3 4 5 6
1
1	                  1
*/ 
using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        List<int> joinedList = new List<int>();

        //join the lists
        for (int i = 0; i < firstList.Count; i++)
        {
            joinedList.Add(int.Parse(firstList[i]));
        }
        for (int j = 0; j < secondList.Count; j++)
        {
            joinedList.Add(int.Parse(secondList[j]));
        }

        joinedList.Sort(); //sort the list
        joinedList = joinedList.Distinct().ToList(); //remove repeating numbers
 
        //Output
        foreach (var element in joinedList)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}