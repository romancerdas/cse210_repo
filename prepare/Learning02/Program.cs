using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2024;
        job1._endYear = 2025;
        
        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2020;


        Resume resume1 = new Resume();
        resume1._name = "Roman";
        resume1._jobs = [job1,job2];

        resume1.Display();
    }
}