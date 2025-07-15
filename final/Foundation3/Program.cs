using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        // Initializations for new Lecture 
        Address lectureAddress = new Address("123 University Ave", "Springfield", "IL", "USA");

        DateTime lectureDate = new DateTime(2025, 7, 15);   // July 15, 2025
        DateTime lectureTime = new DateTime(1, 1, 1, 19, 0, 0); // 7:00 PM (date part ignored)

        Lecture lecture = new Lecture("Modern AI Ethics", "A deep dive into the ethical challenges of AI development.", lectureDate, lectureTime, lectureAddress, "Dr. Jane Smith", 150);



        // Initialization for new Reception
        Address receptionAddress = new Address("456 Celebration Blvd", "Orlando", "FL", "USA");

        DateTime receptionDate = new DateTime(2025, 7, 22); // July 22, 2025
        DateTime receptionTime = new DateTime(1, 1, 1, 18, 30, 0); // 6:30 PM

        Reception reception = new Reception("Annual Company Gala", "Join us for an evening of celebration, networking, and dinner.", receptionDate, receptionTime, receptionAddress, "rsvp@company.com");



        // Initialization for new Address
        Address parkAddress = new Address("789 Park Lane", "Seattle", "WA", "USA");

        DateTime picnicDate = new DateTime(2025, 8, 5); // Aug 5, 2025
        DateTime picnicTime = new DateTime(1, 1, 1, 12, 0, 0); // 12:00 PM

        Gathering gathering = new Gathering("Summer Picnic in the Park", "Bring your family and friends for a fun afternoon picnic.", picnicDate, picnicTime, parkAddress, "Sunny with light breeze");



        Console.WriteLine($"{lecture.GetStandardDescription()} \n{lecture.GetShortDescription()} \n{lecture.GetFullDescription()}");

        Console.WriteLine($"{reception.GetStandardDescription()} \n{reception.GetShortDescription()} \n{reception.GetFullDescription()}");

        Console.WriteLine($"{gatheirng.GetStandardDescription()} \n{gathering.GetShortDescription()} \n{gathering.GetFullDescription()}");

    }
}