public class Reception : Event
{
    private string RSVP;
    public string DisplayReceptionDetails()
    {
        return $"Title: {title}\nDate: {date}\nTime: {time}\nDescription: {description}\nAddress: {address}\nRSVP: {RSVP}/{numberOfAttendees}";
    }

    public void SetRSVP(string rsvp)
    {
        this.RSVP = rsvp;
    }
}