using System;

class Program
{
    static void Main(string[] args)
    {
         Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak Ave", "Sometown", "NY", "Canada");

        Lecture lecture = new Lecture("Introduction to AI", "Learn the basics of artificial intelligence", new DateTime(2024, 4, 10), new TimeSpan(15, 0, 0), address1, "Dr. Smith", 50);
        Reception reception = new Reception("Networking Mixer", "Join us for drinks and networking", new DateTime(2024, 4, 15), new TimeSpan(18, 0, 0), address2, "info@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Picnic in the Park", "Enjoy a day in the sun with friends", new DateTime(2024, 4, 20), new TimeSpan(12, 0, 0), address1, "Sunny with a high of 75°F");

        Console.WriteLine("Standard Message:");
        Console.WriteLine(lecture.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Full Message:");
        Console.WriteLine(lecture.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Message:");
        Console.WriteLine(reception.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Full Message:");
        Console.WriteLine(reception.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Message:");
        Console.WriteLine(gathering.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Full Message:");
        Console.WriteLine(gathering.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(gathering.GenerateShortDescription());
    }
}