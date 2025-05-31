using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference("Ether", 12, 6);
        string text = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.DisplayFullScripture();

            if (scripture.AllWordsHidden() == true)
            {

                break;
            }

            Console.WriteLine("\n Press enter to hide words or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(2);
            }
        }
    }
}
