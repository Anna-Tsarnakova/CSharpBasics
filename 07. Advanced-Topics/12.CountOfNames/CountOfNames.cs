/* Problem 12. Count of Names
Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. 
Use the input and output format from the examples below. Examples:
Input	                             Output
Peter Steve Nakov Steve Alex Nakov	 Alex -> 1
                                     Nakov -> 2
                                     Peter -> 1
                                     Steve -> 2
Nakov Nakov Nakov SoftUni Nakov	     SoftUni -> 1
                                     Nakov -> 5  
*/
using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        List<string> namesList = new List<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        Dictionary<string, int> namesDictionary = new Dictionary<string, int>();

        foreach (string name in namesList)
        {
            int count = 0;
            if (namesDictionary.ContainsKey(name))
            {
                count = namesDictionary[name];
            }
            namesDictionary[name] = count + 1;
        }

        foreach (KeyValuePair<string, int> name in namesDictionary.OrderBy(name => name.ToString()))
        {
            Console.WriteLine("{0} -> {1}", name.Key, name.Value);
        }
    }
}

