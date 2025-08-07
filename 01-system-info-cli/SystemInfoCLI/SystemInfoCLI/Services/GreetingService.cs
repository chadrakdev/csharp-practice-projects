namespace SystemInfoCLI.Services;

public class GreetingService
{
    public void WelcomeUser()
    {

        Console.Write("Welcome! \nPlease enter your name: ");
        var name = Console.ReadLine()?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Guest";
        }
        
        Console.WriteLine("\nUser Details \n---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Current user: {Environment.UserName}");
        Console.WriteLine($"Machine name: {Environment.MachineName}");
        Console.WriteLine($"OS Version: {Environment.OSVersion}");

    }
}