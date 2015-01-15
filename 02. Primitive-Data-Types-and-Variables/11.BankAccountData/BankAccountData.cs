/* Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account. 
Declare the variables needed to keep the information for a single bank account 
using the appropriate data types and descriptive names.
*/
using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Petrov";
        decimal balance = 20085.60M;
        string bankName = "Fibank";
        string IBAN = "BGFI2876328723";
        string cardOne = "MAESTRO: 2410011110001";
        string cardTwo = "VISA: 1200666600002";
        string cardThree = "MASTERCARD: 2300012340003";

        Console.WriteLine("Holder name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Available amount of money (balance): {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN {0}", IBAN);
        Console.WriteLine("{0} \n{1} \n{2}", cardOne, cardTwo, cardThree);
    }
}

