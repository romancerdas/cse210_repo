class ReflectActivity : PromptActivity
{
    private List<string> _listOfFollowUpQuestions;

    public ReflectActivity(string name, string description, int duration, List<string> listOfPrompts, List<string> listOfFollowUpQuestions)
    : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration, listOfPrompts)
    {
        _listOfFollowUpQuestions = listOfFollowUpQuestions;
    }

    public string GetRandomFollowUp() {
        int randomInt = common.RandomNumberGenerator.getRandomNumber(_listOfFollowUpQuestions.Count());
        string randomFollowUp = _listOfFollowUpQuestions[randomInt];
        return randomFollowUp;

    }
    public void displayQuestion()
    {
        Console.WriteLine("Consider the following prompt: ");
        displayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");

    }
    public void runActivity()
    {
        Animation animation = new Animation();
        startMessage();
        displayQuestion();
        string userResponse = Console.ReadLine();
        DateTime currentTime = DateTime.Now;
        while ((DateTime.Now - currentTime).TotalSeconds < _duration)
        {
            Console.WriteLine(GetRandomFollowUp());
            animation.runAnimation(3);
            if ((DateTime.Now - currentTime).TotalSeconds > _duration)
            {
                break;
            }
        }
        endMessage();
    } 
}