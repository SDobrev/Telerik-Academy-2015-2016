﻿//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();

        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();

        Console.Write("Company fax: ");
        string compFax = Console.ReadLine();

        Console.Write("Company web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string manFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string manLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Manager phone number: ");
        string manPhoneNum = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company details.");
        Console.WriteLine("Name: {0}", compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Fax: {0}", compFax);
        Console.WriteLine("Web site: {0}", compFax);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manFirstName, manLastName, age, manPhoneNum);

    }
}