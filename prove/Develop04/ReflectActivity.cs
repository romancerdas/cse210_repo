class ReflectActivity : PromptActivity
{
    private List<string> _listOfQuestions;

    public ReflectActivity(string name, string description, int duration, List<string> listOfPrompts, List<string> listOfQuestions)
    : base(name, description, duration, listOfPrompts)
    {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _listOfQuestions = listOfQuestions;
    }

    public void displayQuestion()
    {
        Console.WriteLine("Consider the following prompt: ");
        displayPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");

    }
    void runActivity()
    {
        startMessage();
        displayQuestion();
    }
}