using Command.Command;
using Command.Invoker;
using Command.Receiver;

var invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));

var receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();

Console.ReadKey();