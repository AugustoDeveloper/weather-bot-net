namespace Weather.Bot.Integrations.Configurations
{
    public interface IWeatherApiConfiguration
    {
        string BaseUri { get; }
        string Timeout { get; }
        string Key { get; }
    }
}