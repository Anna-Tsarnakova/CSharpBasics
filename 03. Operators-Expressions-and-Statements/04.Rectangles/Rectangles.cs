/* Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height. 
Examples:
width	height	perimeter  area
3	     4	    14	       12
2.5	     3	    11	       7.5
5	     5	    20	       25
*/

using System;
using System.Threading;
using System.Globalization;
class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("The rectangle's perimeter is: {0}", perimeter);
        Console.WriteLine("The rectangle's area is: {0}", area);
    }
}

