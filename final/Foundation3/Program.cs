using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Griffin Blvd", "Eagle Town", "Idaho", "USA");
        Address address2 = new Address("55 Pickle Ave", "Saltopia", "Maine", "USA");
        Address address3 = new Address("3330 Dr. Pepper Ln", "Soda Pop City", "Texas", "USA");

        Lecture lecture1 = new Lecture("Intro to Astrophysics", "A beginner-friendly talk on black holes and stars.", "August 5, 2026", "6:00 PM", address1, "Dr. Elena Cho", 100);

        Reception reception1 = new Reception("Annual Fundraiser Gala", "An evening of dinner and networking to support the foundation.", "September 12, 2026", "7:00 PM", address2, "rsvp@fundraisergala.com");

        OutdoorGathering gathering1 = new OutdoorGathering("Community Picnic", "A relaxed outdoor picnic for neighbors to connect.", "July 25, 2026", "12:00 PM", address3, "Sunny, 78°F");
    
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(gathering1.GetStandardDetails());
        Console.WriteLine(gathering1.GetFullDetails());
        Console.WriteLine(gathering1.GetShortDescription());
        Console.WriteLine();
    
    }
}