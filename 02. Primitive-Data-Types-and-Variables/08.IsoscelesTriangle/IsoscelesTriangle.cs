/* Problem 8. Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the console so you may need to change 
the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. 
Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, 
regardless of how much effort you put to fix it.
*/

using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char copyright = '\u00A9';
        string emptySpace = " ";

        Console.WriteLine("{0}" + "{0}" + "{0}" + "{1}", emptySpace, copyright);
        Console.WriteLine("{0}" + "{0}" + "{1}" + "{0}" + "{1}", emptySpace, copyright);
        Console.WriteLine("{0}" + "{1}" + "{0}" + "{0}" + "{0}" + "{1}", emptySpace, copyright);
        Console.WriteLine("{1}" + "{0}" + "{1}" + "{0}" + "{1}" + "{0}" + "{1}", emptySpace, copyright);


        //Second solution with loops
        char copyRight = '\u00A9';

        int a = 4; //side a = b = 4 copyrights
      
        for (int i = 0; i < a - 1; i++) //rows
        {
            for (int j = 1; j <= a + i; j++) //spaces in the row
            {
                if (j == a - i || j == a + i) 
                {
                    Console.Write(copyRight);
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }

        for(int k = 1; k <= (2 * a) - 1; k++) //the lastest row, k->copyright symbols and empty space in the lastest row
        {
            if(k % 2 == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write(copyRight);
            }
        }

        Console.WriteLine();

        }
    }

