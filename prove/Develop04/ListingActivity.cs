class ListingActivity : PromptActivity
{

    public ListingActivity(string name, string description, int duration, List<string> listOfPrompts)
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration, new List<string> { "Who are people that you appreciate?, What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"})
    {
    }

    public void runActivity()
    {
        startMessage();
    }
}