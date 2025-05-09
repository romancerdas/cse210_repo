using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void displayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string promptUserName()
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        static int promptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumberAsString = Console.ReadLine();
            int userNumberAsInt = int.Parse(userNumberAsString);
            return userNumberAsInt;
        }

        static int squareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        
        static void displayResults(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}.");
        }

        static void main()
        {
            displayWelcome();
            displayResults(promptUserName(),squareNumber(promptUserNumber()));
        }
        main();
    }
}