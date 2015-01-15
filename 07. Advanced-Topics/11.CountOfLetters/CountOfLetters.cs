/* Problem 11. Count of Letters
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
The letters should be listed in alphabetical order. Use the input and output format from the examples below. 
Examples:
Input	                               Output
b b a a b	                           a -> 2
                                       b -> 3
h d h a a a s d f d a d j d s h a a	   a -> 6
                                       d -> 5
                                       f -> 1
                                       h -> 3
                                       j -> 1
                                       s -> 2
*/ 
using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        List<string> letters = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        Dictionary<string, int> lettersDictionary = new Dictionary<string, int>();

        foreach (string letter in letters)
        {
            int count = 0;
            if (lettersDictionary.ContainsKey(letter))
            {
                count = lettersDictionary[letter];
            }
            lettersDictionary[letter] = count + 1;
        }

        foreach (KeyValuePair<string, int> letter in lettersDictionary.OrderBy(letter => letter.ToString()))
        {
            Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
        }
    }
}
