using SystemInfoCLI.Services;

namespace SystemInfoCLI;

class Program
{
    static void Main(string[] args)
    {
        var greetingService = new GreetingService();
        var timeService = new TimeService();

        greetingService.WelcomeUser();
        Console.WriteLine(timeService.GetCurrentTimeFormatted());
    }
}
