//Problem 4. Number Comparer

//    Write a program that gets two numbers from the console and prints the greater of them.
//    Try to implement this without if statements.



using System;

class numComparison
{
    static void Main()
    {
        Console.Write("Insert the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double greater = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("The bigger number is: " + greater);
    }
}

