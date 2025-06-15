using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        bool start = true;

        while (start == true)
        {
            Console.WriteLine("Please select an option: \n1. Breathing Activity \n2. Reflection Activity \n3. Listing Activity \n4. Quit");
            Console.Write("> ");
            string response = Console.ReadLine();
            if (response == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.", 0);
                breathing.runActivity();
            }
            if (response == "2")
            {
                ReflectActivity reflect = new ReflectActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." }, new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" });
                reflect.runActivity();
            }
            if (response == "3")
            {
                ListingActivity list = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, new List<string> { "Who are people that you appreciate?, What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" });
                list.runActivity();
            }
            if (response == "4")
            {
                break;
            }
        }
    }
}



