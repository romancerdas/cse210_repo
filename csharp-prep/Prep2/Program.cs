using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Enter grade percentage: ");
        string valueinstring = Console.ReadLine();

        int valueinint = int.Parse(valueinstring);

        string letter_grade = "";

        if (valueinint >=90)
        {
            letter_grade = "A";
        }
        else if (valueinint >=80)
        {
            letter_grade = "B";
        }
        else if (valueinint >=70)
        {
            letter_grade = "C";
        }
        else if (valueinint >= 60)
        {
            letter_grade = "D";
        }
        else if (valueinint <60)
        {
            letter_grade = "F";
        }
        Console.WriteLine($"Your grade is {letter_grade}.");
        if (valueinint >=70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}