public class Lecture : Event
{
    // Limited Capacity and a speaker
    private int capacity;
    private string speaker;

    

    public void SetCapacity(int capacity)
    {
        this.capacity = capacity;
    }
    public void SetSpeaker(string speaker)
    {
        this.speaker = speaker;
    }

    public bool IsFull()
    {
        return numberOfAttendees >= capacity;
    }
    public string DisplayLectureDetails()
    {
        if (IsFull() == true)
        {
            return $"Lecture by {speaker} is full. Current attendees: {numberOfAttendees}/{capacity}.";
        }

        return $"Title: {title}, Speaker: {speaker}\ncurrent attendees: {numberOfAttendees}/{capacity}\ndate: {date}\ntime: {time}\ndescription: {description}\naddress: {address}";
    }

}