//Problem 10. Fibonacci Numbers

//    Write a program that reads a number n and prints on the console the first n members 
//    of the Fibonacci sequence (at a single line, separated by comma and space - ,) :
//    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

//Note: You may need to learn how to use loops.

using System;

class printFibonacci
{
    static void Main()
    {
        Console.Write("Enter number of members: ");
        int numberOfMembers = int.Parse(Console.ReadLine());
        int firstMember = 0;
        int secondMember = 1;
        int nextMember;
        if (numberOfMembers == 1)
        {
            Console.WriteLine(firstMember);
        }
        else if (numberOfMembers == 2)
        {
            Console.WriteLine("{0}, {1}", firstMember, secondMember);
        }
        else
        {
            Console.Write("{0}, {1}, ", firstMember, secondMember);
            for (int counter = 2; counter < numberOfMembers; counter++)
            {
                nextMember = firstMember + secondMember;
                if (counter == numberOfMembers - 1)
                {
                    Console.Write(nextMember + "\n");
                    break;
                }
                Console.Write(nextMember + ", ");
                firstMember = secondMember;
                secondMember = nextMember;
            }
        }
    }
}

