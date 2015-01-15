/* Problem 5. Boolean Variable
Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. 
Print it on the console.
*/

using System;
class BooleanVariable
{
    static void Main()
    {
        bool isFemale;
        Console.Write("Your gender is (m/f): ");
        string gender = Console.ReadLine();

        if (gender == "f")
        {
            isFemale = true;
            Console.WriteLine("Your gender is female! " + isFemale);
        }
        else if (gender == "m")
        {
            isFemale = false;
            Console.WriteLine("Your gender is female! " + isFemale);
        }
        else  //If you input a different value, print an error message.
        {
            Console.WriteLine("Error! Invalid input!");
        }

    }
}

