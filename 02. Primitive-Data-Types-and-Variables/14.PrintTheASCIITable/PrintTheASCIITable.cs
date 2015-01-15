/* Problem 14.* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and 
write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). 
Note that some characters have a special purpose and will not be displayed as expected. 
You may skip them or display them differently. You may need to use for-loops (learn in Internet how).
*/

using System;
using System.Text;

internal class PrintTheASCIITable
{
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine();

        for (int i = 0; i < 256; i++)
        {
            // Get ascii character.
           // char character = (char) i;

            // Get display string.
            string display;
            if (char.IsWhiteSpace((char)i) || char.IsControl((char)i))
            {
                display = "Control";
            }

            else
            {
                display = Convert.ToString((char)i);
            }
            // Write table row.
            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }



    }
}
    

