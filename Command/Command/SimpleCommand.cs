using Command.Interface;

namespace Command.Command;

// Exemple of a simple command that does not delegate to any receiver
public class SimpleCommand : ICommand
{
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
        _payload = payload;
    }

    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
    }
}
