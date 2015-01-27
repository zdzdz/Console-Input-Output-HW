//Problem 9. Sum of n Numbers

//    Write a program that enters a number n and after that enters 
//    more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.


using System;

class addNumbers
{
    static void Main()
    {
        Console.Write("Please enter how many numbers you want to add: ");
        double num = double.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= num; i++)
        {
            Console.Write("Please enter a number: ");
            double newNumber = double.Parse(Console.ReadLine());
            sum += newNumber;
        }

        Console.WriteLine(sum);
    }
}

