namespace Task2;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string ? username = null;
        string message = (username == null) ? "username is empty" : null;
        Console.WriteLine(message);
        
        Console.WriteLine(username ?? "username is not avaiable" );

        username ??= " bardan g";
        Console.WriteLine($"Updated username: {username}");


    }
}