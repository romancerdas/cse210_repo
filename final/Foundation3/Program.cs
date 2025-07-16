using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        

        // Lecture
        Address lectureAddress = new Address("123 University Ave", "Springfield", "IL", "USA");
        DateTime lectureDateTime = new DateTime(2025, 7, 15, 19, 0, 0); // July 15, 2025, 7:00 PM
        Lecture lecture = new Lecture("Modern AI Ethics", "A deep dive into the ethical challenges of AI development.", lectureDateTime, lectureAddress, "Dr. Jane Smith", 150);


        // Reception
        Address receptionAddress = new Address("456 Celebration Blvd", "Orlando", "FL", "USA");
        DateTime receptionDateTime = new DateTime(2025, 7, 22, 18, 30, 0); // July 22, 2025, 6:30 PM
        Reception reception = new Reception("Annual Company Gala", "Join us for an evening of celebration, networking, and dinner.", receptionDateTime, receptionAddress, "rsvp@company.com");


        // Gathering
        Address parkAddress = new Address("789 Park Lane", "Seattle", "WA", "USA");
        DateTime picnicDateTime = new DateTime(2025, 8, 5, 12, 0, 0); // Aug 5, 2025, 12:00 PM
        Gathering gathering = new Gathering("Summer Picnic in the Park", "Bring your family and friends for a fun afternoon picnic.", picnicDateTime, parkAddress, "sunny");


        Console.WriteLine("Lecture Descriptions");
        Console.WriteLine($"\nStandard \n{lecture.GetStandardDescription()} \n\nShort \n{lecture.GetShortDescription()} \n\nFull \n{lecture.GetFullDescription()}");
        Console.WriteLine();

        Console.WriteLine("Reception Description");
        Console.WriteLine($"\nStandard \n\n{reception.GetStandardDescription()} \n\nShort \n{reception.GetShortDescription()} \n\nFull \n{reception.GetFullDescription()}");
        Console.WriteLine();

        Console.WriteLine("Gathering Descriptions");
        Console.WriteLine($"\nStandard \n\n{gathering.GetStandardDescription()} \n\nShort \n{gathering.GetShortDescription()} \n\nFull \n{gathering.GetFullDescription()}");
        Console.WriteLine();
    }
}