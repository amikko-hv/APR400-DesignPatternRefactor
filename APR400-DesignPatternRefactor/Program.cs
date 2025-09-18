using APR400_DesignPatternRefactor;

var users = new List<User>
{
    new User("Alice", "alice@email.com"),
    new User("Bob", "bob@email.com")
};

var notifier = new Notifier();

foreach (var user in users)
{
    notifier.SendEmail(user, "Welcome to the system!");
}

Console.WriteLine("Notifications sent.");
