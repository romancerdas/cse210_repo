using System;

public class PromptGenerator
{
    public List<string> _promptList = new List<string>
    {
        "Describe a place from your childhood that still feels magical.",
        "What’s something you believed as a child that you now see differently?",
        "If you could relive one day from your past, which would it be and why?",
        "Write a letter to your future self 10 years from now.",
        "What does 'home' mean to you? Is it a place, a person, a feeling?",
        "Imagine waking up with a superpower for a day. What would you do?",
        "Describe a moment when you felt truly proud of yourself.",
        "What’s one fear you’d like to overcome, and what’s holding you back?",
        "Reflect on a conversation that changed the way you see the world.",
        "If you could spend a day with any historical figure, who would it be and what would you ask them?"
    };
    Random _randomNumber = new Random();

    public string givePrompt()
    {
        int randomNumber = _randomNumber.Next(_promptList.Count);
        return _promptList[randomNumber];
    }
}