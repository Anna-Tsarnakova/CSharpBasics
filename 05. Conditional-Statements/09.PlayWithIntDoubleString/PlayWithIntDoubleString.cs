/* Problem 9. Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
If the variable is int or double, the program increases it by one. 
If the variable is a string, the program appends "*" at the end. 
Print the result at the console. Use switch statement. 
Example:
program      	        user		     program	            user
Please choose a type:                    Please choose a type:
1 --> int                                1 --> int                         
2 --> double                             2 --> double
3 --> string	        3		         3 --> string           2

Please enter a string:	hello		     Please enter a double:	1.5
hello*		                        	  2.5	
 */

using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please choose a type: \n1 --> int  \n2 --> double \n3 --> string");
        
        string a = Console.ReadLine();
        switch (a)
        {
            case "1": 
                Console.Write("Please enter an integer: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} => {1}", intNumber, intNumber + 1);
                break;
            case "2": 
                Console.Write("Please enter a double: "); 
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("{0} => {1}", doubleNumber, doubleNumber + 1);
                break;
            case "3": Console.Write("Please enter a string: ");
                string myString = Console.ReadLine();
                Console.WriteLine("{0} => {1}", myString, myString + "*");
                break;
            default: Console.WriteLine("No such а choice"); break;
        }
    }
}

