using System;

public class Journal
{
    public List<string> _entryAsList = new List<string>();

    public void DisplayEntries()
    {
        foreach (string entry in _entryAsList)
        {
            Console.WriteLine(entry);
        }
    }
    public void LoadEntry()
    {
        DisplayEntries();
        
    }
}