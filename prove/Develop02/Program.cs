using System;
using System.Data.Common;
using System.IO;
using System.IO.Enumeration;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        /* Create a new instance of the class Journal*/
        Journal newJournal = new Journal();

        string menuSelect = "0";
        string filename;

        while (menuSelect != "5")
        {
            /* Display menu*/
            Console.WriteLine("Please Select an option:");
            Console.Write("1.New Journal Entry\n2.View Unsaved Entries\n3.Save Journal to a File\n4.Load a Journal from a File\n5.Quit\n> ");
            menuSelect = Console.ReadLine();

            if (menuSelect == "1")
            {
                Console.Write("Enter text to add to the journal:\n>");
                newJournal._entryAsList.Add(Console.ReadLine());
            }
            
            else if (menuSelect == "4")
            {
                Console.WriteLine("What is the name of the file? ");
                filename = Console.ReadLine();

                string[] entries = System.IO.File.ReadAllLines(filename);

                // test to see if entries display 
                // foreach (string entry in entries)
                // {
                //     Console.Write($"{entry}\n");
                // }

            }

            /* view entries from a saved file or recently written journal entries*/ //*THIS IS CHATGPT CODE, REVIEW BEFORE MOVING ON*/
            else if (menuSelect == "2")
            {
                if (!string.IsNullOrEmpty(filename) && File.Exists(filename))
                {
                    Console.WriteLine("Entries loaded from file:\n");
                    string[] fileEntries = File.ReadAllLines(filename);

                    foreach (string entry in fileEntries)
                    {
                        Console.WriteLine(entry);
                    }
                }
                else
                {
                    Console.WriteLine("Unsaved entries in memory:\n");
                    newJournal.DisplayEntries();
                }
            }

            /* write entries to a file*/
            else if (menuSelect == "3")
            {
                Console.WriteLine("What is the file name? ");
                filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (string journalEntry in newJournal._entryAsList)
                    {
                        outputFile.WriteLine(journalEntry);
                    }
                }

            }
            /* load journal from file*/

        }
    }
}