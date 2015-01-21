using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday in format dd.mm.yyyy or dd/mm/yyyy:");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        int age = today.Year - birthday.Year;   //Calculate the age to current date
        birthday = new DateTime(today.Year, birthday.Month, birthday.Day);    //Assign my birthday on current year
        if (today < birthday)    //if my birthday isn't still pass this year, decrease the age
        {
            age = age - 1;
        }

        Console.WriteLine("You are {0} years old!", age);
        int ageAfterYears = age + 10;
        Console.WriteLine("You will be {0} years old after ten years!", ageAfterYears);
    }
}
