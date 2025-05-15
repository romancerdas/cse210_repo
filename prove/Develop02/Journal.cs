using System;

public class Journal
{
    public Dictionary<string,string> _entryDict = new Dictionary<string, string>();

    public void DisplayEntries (_entryDict)
    {
        foreach (var jEntry in (_entryDict)
        {
            Console.WriteLine(jEntry);
        }
    }
    public void LoadEntry()
    {
        DisplayEntries();
        
    }
}