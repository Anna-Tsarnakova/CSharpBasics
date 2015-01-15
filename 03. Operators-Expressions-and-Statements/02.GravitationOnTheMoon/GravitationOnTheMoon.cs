/* Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth. 
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
Examples:
weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129
*/ 

using System;
using System.Threading;
using System.Globalization;

class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter your weight on the Earth: ");
        double earthWeigth = double.Parse(Console.ReadLine());
        double moonWeigth = 0.17 * earthWeigth;
        Console.WriteLine("Your weight on the moon is: {0}", moonWeigth);
    }
}
