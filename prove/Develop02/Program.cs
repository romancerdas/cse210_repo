using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        /* Create a new instance of the class Journal*/
        Journal newJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string menuSelect = "0";
        string filename = "";

        while (menuSelect != "5")
        {
            /* Display menu*/
            Console.WriteLine("Please Select an option:");
            Console.Write("1.New Journal Entry\n2.View Unsaved Entries\n3.Save Journal to a File\n4.Load a Journal from a File\n5.Quit\n> ");
            menuSelect = Console.ReadLine();

            if (menuSelect == "1")
            {
                Console.Write("Enter text to add to the journal:\n");

                string givenPrompt = promptGenerator.givePrompt();
                Console.WriteLine($"{givenPrompt}\n>");

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newJournal._entryAsList.Add($"{dateText} -- {givenPrompt} -- {Console.ReadLine()}");
            }

            /* load a journal from a file*/
            else if (menuSelect == "4")
            {
                Console.WriteLine("What is the name of the file? ");
                filename = Console.ReadLine();

                /* read each line in the file*/
                string[] entries = System.IO.File.ReadAllLines(filename);

                /* write each entry from the file back into local memory for manipulation*/
                foreach (string entry in entries)
                {
                    newJournal._entryAsList.Add(entry);
                }

            }

            /* view local entries */ 
            else if (menuSelect == "2")
            {
                /* run code if filename has been entered*/
                if (filename != "")
                {
                    foreach (string entry in newJournal._entryAsList)
                    {
                        Console.WriteLine(entry);
                    }
                }
                /* run code if variable filename has not been changed by user*/
                else
                {
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
        }
    }
}