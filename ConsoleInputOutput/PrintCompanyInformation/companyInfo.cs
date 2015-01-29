//Problem 2. Print Company Information

//    A company has name, address, phone number, fax number, web site and manager. 
//    The manager has first name, last name, age and a phone number.
//    Write a program that reads the information about a company and its manager 
//    and prints it back on the console.


using System;

class companyInfo
{
    static void Main()
    {
        Console.Write("Please insert the compay's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please insert the compay's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please insert the compay's phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Please insert the compay's fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Please insert the compay's website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Please insert manger's first name: ");
        string managersFirstName = Console.ReadLine();
        Console.Write("Please insert manger's last name: ");
        string managersLastName = Console.ReadLine();
        Console.Write("Please insert manager's age: ");
        int mangersAge = int.Parse(Console.ReadLine());
        Console.Write("Please insert manager's phone number: ");
        string managersPhoneNumber = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        if (string.IsNullOrWhiteSpace(companyPhoneNumber))
        {
            Console.WriteLine("Tel. (no number)");
        }
        else
        {
            Console.WriteLine("Company phone number: " + companyPhoneNumber);
        }

        if (string.IsNullOrWhiteSpace(companyFaxNumber))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + companyFaxNumber);
        }
        Console.WriteLine("Website: " + companyWebsite);

        Console.Write("Manager: " + managersFirstName + " " + managersLastName + " ");
        Console.WriteLine("(age: " + mangersAge + " tel. " + managersPhoneNumber);
        

        
        
    }
}

