/* Problem 14. Longest Word in a Text
Write a program to find the longest word in a text. Examples:
Input	                                                                                    Output
Welcome to the Software University.	                                                        University
The C# Basics course is awesome start in programming with C# and Visual Studio.            	programming
 */ 
using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ', '.', ':', ';', ',', '-', '!', '?');
    
        var longestWords = text.Where(w => w.Length == text.Max(m => m.Length));
        Console.WriteLine("{0}", string.Join(", ", longestWords.ToArray()));
    }
}