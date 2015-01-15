/* Problem 6. Strings and Objects
Declare two string variables and assign them with “Hello” and “World”. 
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). 
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
 */

using System;
class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object objHelloWorld = hello + " " + world;
        string strHelloWorld = (string)objHelloWorld;
        Console.WriteLine("The first string is: {0}", hello);
        Console.WriteLine("The second string is: {0}", world);
        Console.WriteLine("The object variable is: {0}", objHelloWorld);
        Console.WriteLine("The third string variable is: {0}", strHelloWorld);
    }
}

