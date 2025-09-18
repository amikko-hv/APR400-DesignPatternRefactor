namespace APR400_DesignPatternRefactor;

public class Notifier
{
    public void SendEmail(User user, string message)
    {
        Console.WriteLine($"Email to {user.Email}: {message}");
    }

    // Could add more methods for SMS, Push, etc.
}
