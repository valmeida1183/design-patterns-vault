using Command.Interface;

namespace Command.Invoker;
public class Invoker
{
    // Another approach is to create a list of ICommand and creat an method called "addCommand" then in the DoSomethingImportant iterate over commands and execute they.
    private ICommand? _onStart;
    private ICommand? _onFinish;

    public void SetOnStart(ICommand command)
    {
        _onStart = command;
    }
    public void SetOnFinish(ICommand command)
    {
        _onFinish = command;
    }

    // The Invoker does not depend on concrete command or receiver classes.
    // The Invoker passes a request to the command object.
    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Does anybody want something done before I begin?");

        if (_onStart is ICommand)
        {
            _onStart.Execute();
        }

        Console.WriteLine("Invoker: ...doing something really important...");

        Console.WriteLine("Invoker: Does anybody want something done after I finish?");

        if (_onFinish is ICommand)
        {
            _onFinish.Execute();
        }
    }
}
