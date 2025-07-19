using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activitylist = new List<Activity>();

        Running running1 = new Running("18 June 2022", 30, 3);
        Bike bike1 = new Bike("30 Jan 2019", 25, 3.1);
        Swimming swimming1 = new Swimming("01 Dec 2017", 15, 20);

        activitylist.Add(running1);
        activitylist.Add(bike1);
        activitylist.Add(swimming1);

        foreach (Activity a in activitylist)
        {
            Console.WriteLine($"{a.GetSummary()}");
        }
    }
}