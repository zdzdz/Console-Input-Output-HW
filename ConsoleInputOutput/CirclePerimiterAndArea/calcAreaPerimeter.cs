//Problem 3. Circle Perimeter and Area

//    Write a program that reads the radius r of a circle and prints its perimeter and 
//    area formatted with 2 digits after the decimal point.


using System;

class calcAreaPerimeter
{
    static void Main()
    {
        Console.Write("Insert the radius: ");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * radius;
        double circleArea = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Circle's perimeter is: {0:0.00}",circlePerimeter);
        Console.WriteLine("Circle's are is: {0:0.00}",circleArea);
    }
}

