/* Problem 11.* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
Examples:
numbers	number as words
0	    Zero
9	    Nine
10	    Ten
12	    Twelve
19	    Nineteen
25	    Twenty five
98	    Ninety eight
273	    Two hundred and seventy three
400	    Four hundred
501	    Five hundred and one
617	    Six hundred and seventeen
711	    Seven hundred and eleven
999	    Nine hundred and ninety nine
*/

using System;
class NumberAsWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int units = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = (number / 100) % 10;

        string[] unitsWords = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", 
                               "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tensWords = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] hundredsWords = { "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };


        if (number <= 999 && number >= 0)
        {

            if (number > 99) // hundreds
            {
                Console.Write(hundredsWords[hundreds - 1]);

                int twoDigitNumber = number % 100;
                if (twoDigitNumber > 19)
                {
                    Console.Write(" and {0}", tensWords[tens - 2].ToLower());
                    if (units != 0)
                    {
                        Console.WriteLine(" " + unitsWords[units].ToLower());
                    }
                }
                else
                {
                    Console.WriteLine(" and {0}", unitsWords[twoDigitNumber].ToLower());
                }
            }
            else if (number > 19) // two-digit numbers
            {
                Console.Write(tensWords[tens - 2]);
                if (units != 0)  // units
                {
                    Console.WriteLine(" " + unitsWords[units].ToLower());
                }
            }
            else // single-digit numbers
            {
                Console.WriteLine(unitsWords[number]);
            }
        }
        else
        {
            Console.WriteLine("Out of the range [0…999]!");
        }
    }
}