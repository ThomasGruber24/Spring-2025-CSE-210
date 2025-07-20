public class Outdoor : Event
{
    private string weather;

    public void SetWeather(string weather)
    {
        this.weather = weather;
    }

    public string DisplayOutdoorDetails()
    {
        return $"Title: {title}\nDate: {date}\nTime: {time}\nDescription: {description}\nAddress: {address}\nWeather: {weather}";
    }
}