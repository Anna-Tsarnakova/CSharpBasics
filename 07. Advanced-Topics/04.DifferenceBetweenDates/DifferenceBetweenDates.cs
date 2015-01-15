/* Problem 4. Difference between Dates
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
Examples:
First date
Second date	Days between
17.03.2014
30.04.2014	44

17.03.2014
17.03.2014	0

14.06.1980
5.03.2014	12317

5.03.2014
3.03.2014	-2
 */ 
using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan daysBetween = secondDate - firstDate;
        Console.WriteLine(firstDate <= secondDate ? "{0:%d}" : "-{0:%d}", daysBetween);
    }
}