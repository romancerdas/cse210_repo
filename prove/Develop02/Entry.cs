using System;

public class Entry
{
    public string _date;
    public string _answer;
    public string _question;

    public void display()
    {
        Console.WriteLine($"{_date} -- {_question} -- {_answer}");
    }
}