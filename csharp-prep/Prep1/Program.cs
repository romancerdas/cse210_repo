using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        int x=5;
        string s="asdf";

        Console.WriteLine(x);
        Console.WriteLine(s);

        string q=Console.ReadLine();
        Console.WriteLine(q);

        string y=Console.ReadLine();
        Console.WriteLine($"This is the value that was entered: {y}");
        Console.WriteLine("This is the value that was entered: " + y);


        int r=0;
        if (r>0)
        {
            ;// do nothing
        }
        else if (r=0);
        {
            Console.WriteLine($"The number was {0}");
        }
        string userInput = Console.ReadLine()
        int userInputAsInt = int.Parse(userInput);
    }
}