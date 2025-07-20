using System.Reflection;
using Microsoft.VisualBasic;

public class Event
{
    protected string title;
    protected string date;
    protected string time;
    protected string description;
    protected string address;
    protected string typeOfEvent;
    // This will also handle RSVP.
    protected int numberOfAttendees;



    public void GetTitle(string title)
    {
        this.title = title;
    }

    public void GetDate(string date)
    {
        this.date = date;
    }

    public void GetTime(string time)
    {
        this.time = time;
    }
    // Index 4 - Description
    public void GetDescription(string description)
    {
        this.description = description;
    }
    // Index 5 - Address
    public void GetAddress(string address)
    {
        this.address = address;
    }
    // Index 6 - Number of Attendees
    public void GetNumberOfAttendees(int numberOfAttendees)
    {
        this.numberOfAttendees = numberOfAttendees;
    }
}