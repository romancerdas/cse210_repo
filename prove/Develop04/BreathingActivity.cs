class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.", duration)
    {
    }

    public void runActivity()
    {
        Animation animation = new Animation();
        startMessage();
        DateTime currentTime = DateTime.Now;
        while ((DateTime.Now - currentTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            animation.runAnimation(4);

            Console.WriteLine("Breathe out...");
            animation.runAnimation(4);
        }
        Console.WriteLine();
        endMessage();
    }
}
