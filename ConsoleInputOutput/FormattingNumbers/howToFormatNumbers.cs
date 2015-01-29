//Problem 5. Formatting Numbers

//    Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//        floating-point c
//    The program then prints them in 4 virtual columns on the console. 
//    Each column should have a width of 10 characters.
//        The number a should be printed in hexadecimal, left aligned
//        Then the number a should be printed in binary form, padded with zeroes
//        The number b should be printed with 2 digits after the decimal point, right aligned
//        The number c should be printed with 3 digits after the decimal point, left aligned.


using System;

class howToFormatNumbers
{
    static void Main()
    {
        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        if (0 <= firstNumber && firstNumber <= 500)
        {
            Console.Write("Insert the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Insert the third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            string binary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');

            Console.WriteLine("|{0, -10:X}|{1}|{2, 10:0.00}|{3, -10:0.000}|", firstNumber, binary, secondNumber, thirdNumber);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}

