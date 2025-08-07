namespace SystemInfoCLI.Services;

public class TimeService
{
    public string GetCurrentTimeFormatted()
    {
        return $"System time: {DateTime.UtcNow.ToLocalTime():ddd d MMM HH:mm}";
    }
}