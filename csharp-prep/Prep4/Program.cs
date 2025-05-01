using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
    // // --------------- lists -------------- //
    // // create a variable to hold the list 
    // // List<int> numbers;
    // // // create a list  
    // // numbers = new List<int>();

    // // // combine on the same line
    // // List<string> words = new List<string>();
    // // ---------------------------------------//

    // // ------------ Adding items to a list ------------ //
    // List<string> words = new List<string>();
    // words.Add("phone");
    // words.Add("keyboard");
    // words.Add("mouse");
    // // -------------------------------------------------//

    // // --------- getting a list size ----------------- //
    // Console.WriteLine(words.Count);
    // // ------------------------------------------------ //

    // // ------- iterating through a list ----------------- //
    // foreach (string word in words)
    // {
    //     Console.WriteLine(word);
    // }
    // // ----------------------------------------------------//

    // // --------- indexing -------------------------- //
    
    // for (int i = 0; i < words.Count; i++)
    // {
    //     Console.WriteLine(words[i]);
    // }
    // // ---------------------------------------------//

    // Initialize variables
    int newNumberAsInt;
    List<int> numbers = new List<int>();
    int sumOfAllNumbers = 0;


    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    do
    {
        Console.WriteLine("Enter number: ");
        string newNumberAsString = Console.ReadLine();
        newNumberAsInt = int.Parse(newNumberAsString);
        if (newNumberAsInt != 0)
        {
            numbers.Add(newNumberAsInt);
        }

    } while (newNumberAsInt != 0);

    // iterate through the list and get the sum of all numbers entered
    foreach (int number in numbers)
    {
        sumOfAllNumbers += number;
    }

    // sort list in ascending order
    numbers.Sort();

    Console.WriteLine($"The sum is: {sumOfAllNumbers}");

    // init average variable, cast float on sumOfAllNumbers, and divide by count of numbers
    float average = ((float)sumOfAllNumbers / numbers.Count);
    Console.WriteLine($"The average is {average}.");

    // find the largest number in the list 
    int max = 0;
    int min = 999;
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
        if (number < min)
        {
            min = number;
        }
    }
    Console.WriteLine($"The largest number is {max}.");
    Console.WriteLine($"The smallest number is {min}.");
    }
}