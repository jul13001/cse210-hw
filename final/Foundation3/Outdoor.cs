public class Outdoor : Event
{
    private string _weatherForecast{get; set;}

   public Outdoor(string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base(eventTitle, description, date, time, address)
   {
    _weatherForecast = weatherForecast;
   }

    public override string GetFullDetails()
    {
        return $"{DisplayStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

}