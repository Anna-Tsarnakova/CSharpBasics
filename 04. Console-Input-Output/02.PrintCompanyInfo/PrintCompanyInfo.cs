/* Problem 2. Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
Write a program that reads the information about a company and its manager and prints it back on the console.
 program             | user                         Output:         
 Company name:	     | Software University          Software University   
 Company address:    | 26 V. Kanchev, Sofia         Address: 26 V. Kanchev, Sofia
 Phone number:       | +359 899 55 55 92            Tel. +359 899 55 55 92  
 Fax number:         |          	                Fax: (no fax)
 Web site:           | http://softuni.bg            Web site: http://softuni.bg   
 Manager first name: | Svetlin                      Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)
 Manager last name:  | Nakov                     
 Manager age:	     | 25                            
 Manager phone:      | +359 2 981 981                 
*/

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        if (companyFaxNumber == "")
        {
            companyFaxNumber = "(no fax)";
        }
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} ({2}, {3})", managerFirstName, managerLastName, managerAge,managerPhoneNumber);
        Console.WriteLine();
    }
}

