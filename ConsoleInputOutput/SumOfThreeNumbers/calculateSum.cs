//Problem 1. Sum of 3 Numbers

//    Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class calculateSum
{
    static void Main()
    {
        Console.Write("Please inser the first number: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please inser the second number: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please inser the third number: ");
        double numberC = double.Parse(Console.ReadLine());

        double sum = numberA + numberB + numberC;

        Console.WriteLine("The sum of the numbers is: " + sum);

    }
}

