/* Problem 9.	Remove Names
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
The input and output lists are given as words, separated by a space, each list at a separate line. 
Examples:
Input	                                            Output
Peter Alex Maria Todor Steve Diana Steve
Todor Steve Nakov	                                Peter Alex Maria Diana
Hristo Hristo Nakov Nakov Petya
Nakov Vanessa Maria                                 Hristo Hristo Petya
 */ 
using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        //Remove from the first list all names given in the second list
        foreach (string name in secondList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                if (name == firstList[i])
                {
                    firstList.RemoveAt(i);
                    i--;
                }
            }
        }

        //Output
        foreach (string name in firstList)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();

    }
}

