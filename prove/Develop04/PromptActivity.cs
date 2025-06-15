using System.ComponentModel;
using common;
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
        int randomInt = common.RandomNumberGenerator.getRandomNumber(_listOfPrompts.Count());
        string randomPrompt = _listOfPrompts[randomInt];
        return randomPrompt;
    }

    protected void displayPrompt()
    {
        string prompt = selectPrompt();
        Console.Write($"--- {prompt} ---");
    }
}
