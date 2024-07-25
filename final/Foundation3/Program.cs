using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1600 Amphitheatre Parkway", "Mountain View", "CA", "USA");

        Lecture lecture = new Lecture("Tech Innovations 2024", "A deep dive into the latest tech trends and innovations", "October 15, 2024", "10 AM", address, "Elon Musk", 300);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("1 Infinite Loop", "Cupertino", "CA", "USA");

        Reception reception = new Reception("Apple Keynote 2024", "Unveiling the latest in Apple technology", "September 12, 2024", "11 AM", addressR, "reception@gmail.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("221B Baker Street", "London", "NW1 6XE", "UK");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Detective Fiction: Analyzing Sherlock Holmes", "An in-depth analysis of Arthur Conan Doyle's works", "August 8, 2024", "2 PM", addressOG, "rainy");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}