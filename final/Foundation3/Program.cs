using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        

        // Initialize everything for new Lecture
        Address lectureAddress = new Address("123 University Ave", "Springfield", "IL", "USA");
        DateTime lectureDateTime = new DateTime(2025, 7, 15, 19, 0, 0);
        Lecture lecture = new Lecture("Modern AI Ethics", "A deep dive into the ethical challenges of AI development.", lectureDateTime, lectureAddress, "Dr. Jane Smith", 150);


        // Initialize everything for new Reception
        Address receptionAddress = new Address("456 Celebration Blvd", "Orlando", "FL", "USA");
        DateTime receptionDateTime = new DateTime(2025, 7, 22, 18, 30, 0);
        Reception reception = new Reception("Annual Company Gala", "Join us for an evening of celebration, networking, and dinner.", receptionDateTime, receptionAddress, "rsvp@company.com");


        // Initialize everything for new Gathering
        Address parkAddress = new Address("789 Park Lane", "Seattle", "WA", "USA");
        DateTime picnicDateTime = new DateTime(2025, 8, 5, 12, 0, 0);
        Gathering gathering = new Gathering("Summer Picnic in the Park", "Bring your family and friends for a fun afternoon picnic.", picnicDateTime, parkAddress, "sunny");


        // print descriptions for lecture
        Console.WriteLine("Lecture Descriptions");
        Console.WriteLine($"\nStandard \n{lecture.GetStandardDescription()} \n\nShort \n{lecture.GetShortDescription()} \n\nFull \n{lecture.GetFullDescription()}");
        Console.WriteLine();

        // print descriptions for receptions
        Console.WriteLine("Reception Description");
        Console.WriteLine($"\nStandard \n\n{reception.GetStandardDescription()} \n\nShort \n{reception.GetShortDescription()} \n\nFull \n{reception.GetFullDescription()}");
        Console.WriteLine();

        // print descriptions for gathering
        Console.WriteLine("Gathering Descriptions");
        Console.WriteLine($"\nStandard \n\n{gathering.GetStandardDescription()} \n\nShort \n{gathering.GetShortDescription()} \n\nFull \n{gathering.GetFullDescription()}");
        Console.WriteLine();
    }
}