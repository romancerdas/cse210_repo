using System.ComponentModel;

class PromptActivity : Activity
{
    List<string> _listOfPrompts;

    public PromptActivity(string name, string description, int duration, List<string> listOfPrompts) 
    : base(name, description, duration)
    {
        _listOfPrompts = listOfPrompts;
    }

    protected string selectPrompt()
    {
        return "";
    }

    protected void displayPrompt()
    {
        string prompt = selectPrompt();
        Console.Write($"--- {prompt} ---");
    }
}
