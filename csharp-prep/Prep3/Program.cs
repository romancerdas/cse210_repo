using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {


        // -------------------------while loops----------------------------- //
        // Console.WriteLine("Hello Prep3 World!");

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.WriteLine("Do you want to continue?");
        //     response = Console.ReadLine();
        // }
        // ----------------------------------------------------------- //



        // -----------------------------dowhile loops------------------------ //
        // string response;

        // do
        // {
        //     Console.WriteLine("Do you want to continue?");
        //     response = Console.ReadLine();
        // }
        // while (response == "yes");
        // ----------------------------------------------------------- //

        // ----------------------------for loops------------------------- //
        // // for (type initializes_value; check_condition; increment_step)
        // for (int i=0; i<10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        // ----------------------------------------------------------- //
        
        // -------------------------Foreach loops---------------------------- //
        // // iterate through elements in a collection 
        // foreach (color in colors)
        // {
        //     Console.WriteLine(color);
        // }
        // ----------------------------------------------------------- //

        // --------------------------Random num generator class --------------------------------- //
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1,11);
        // Console.WriteLine(number);
        // ----------------------------------------------------------- //

        string continue_playing = "yes";
        int guessAsInt;
        int magicNumberAsInt;
        



        while (continue_playing == "yes")
        {

            Random randomGenerator = new Random();
            magicNumberAsInt = randomGenerator.Next(1,101);        
            int guessCounter = 0;
            do
            {


                Console.WriteLine("What is your guess?");
                string guessAsString = Console.ReadLine();
                guessAsInt = int.Parse(guessAsString);

                if (guessAsInt == magicNumberAsInt)
                {
                    Console.WriteLine("You guessed it!");

                }
                else if (guessAsInt > magicNumberAsInt)
                {
                    Console.WriteLine("Lower");

                }
                else if (guessAsInt < magicNumberAsInt)
                {
                    Console.WriteLine("Higher");

                }
                guessCounter += 1;
                if (guessAsInt == magicNumberAsInt)
                {
                    Console.WriteLine($"You guessed {guessCounter} times.");
                }
            } while (guessAsInt != magicNumberAsInt);

            Console.WriteLine("Do you want to continue?");
            continue_playing = Console.ReadLine();
        }
    }
}