class ListingActivity : PromptActivity
{

    public ListingActivity(string name, string description, int duration, List<string> listOfPrompts)
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration, new List<string> { "Who are people that you appreciate?","What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"})
    {
    }

    public void runActivity()
    {
        Animation animation = new Animation();
        startMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{selectPrompt()}---");
        animation.runAnimation(3);
        DateTime currentTime = DateTime.Now;
        List<string> responses = new List<string>();
        while ((DateTime.Now - currentTime).TotalSeconds < _duration)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            responses.Add(input);
        }
        endMessage();
    }
}