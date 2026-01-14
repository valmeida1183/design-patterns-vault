using Command.Interface;
using ReceiverLogic = Command.Receiver.Receiver; // Alias to avoid confusion with the Command namespace

namespace Command.Command;

// Example of a complex command that delegates to several objects
public class ComplexCommand : ICommand
{
    private ReceiverLogic _receiver;
    private string _a;
    private string _b;

    public ComplexCommand(ReceiverLogic receiver, string a, string b)
    {
        _receiver = receiver;
        _a = a;
        _b = b;
    }

    public void Execute()
    {
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
