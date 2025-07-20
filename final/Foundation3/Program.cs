using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        lecture.GetTitle("Kevin Flynn: The Grid");
        lecture.GetDate("07/19/2025");
        lecture.GetTime("10:00 AM");
        lecture.GetDescription("A deep dive into the world of The Grid, exploring its history and technology.");
        lecture.GetAddress("Encom Tower, 1234 Flynn Ave, Silicon Valley");
        lecture.SetSpeaker("Kevin Flynn");
        lecture.SetCapacity(100);
        lecture.GetNumberOfAttendees(50);
        Console.WriteLine(lecture.DisplayLectureDetails());
        Console.WriteLine();

        Reception reception = new Reception();
        reception.GetTitle("Sam Flynn and Quorra's Wedding");
        reception.GetDate("07/20/2025");
        reception.GetTime("5:00 PM");
        reception.GetDescription("Join us for the wedding of Sam Flynn and Quorra, celebrating love in the digital age.");
        reception.GetAddress("Encom Tower Rooftop, 1234 Flynn Ave, Silicon Valley");
        reception.SetRSVP("50");
        reception.GetNumberOfAttendees(50);
        Console.WriteLine(reception.DisplayReceptionDetails());
        Console.WriteLine();

        Outdoor outdoorEvent = new Outdoor();
        outdoorEvent.GetTitle("Flynn's Arcade Reunion");
        outdoorEvent.GetDate("07/21/2025");
        outdoorEvent.GetTime("3:00 PM");
        outdoorEvent.GetDescription("A nostalgic gathering at Flynn's Arcade, celebrating the legacy of video games.");
        outdoorEvent.GetAddress("Flynn's Arcade, 5678 Arcade St, Silicon Valley");
        outdoorEvent.SetWeather("Sunny");
        outdoorEvent.GetNumberOfAttendees(30);
        Console.WriteLine(outdoorEvent.DisplayOutdoorDetails());
        Console.WriteLine();
    }
}