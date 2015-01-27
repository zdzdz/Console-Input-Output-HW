//Problem 6. Quadratic Equation

//    Write a program that reads the coefficients a, b and c of 
//    a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).


using System;

class calculateQuadraticEquation
{
    static void Main()
    {
        Console.Write("Insert the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Insert the third number: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4 * a * c;


        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("ax^2 + bx + c has two real roots: x1 = {0:} and x2 = {1:}", x1, x2);
        }

        else if (discriminant == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine("ax^2 + bx + c has one real root: x1 = x2 = {0}", x1);

        }

        else
        {
            Console.WriteLine("ax^2 + bx + c has no real roots.");
            
        }
    }
}

