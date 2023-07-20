namespace Command;

public class Invoker
{
    private readonly Stack<ICommand> _commands;
    public Invoker()
    {
        _commands = new Stack<ICommand>();
    }

    public void Invoke(ICommand command)
    {
        _commands.Push(command);
        command.Execute();
    }

    public void Undo()
    {
        if(!_commands.Any())
            return;
        _commands.Peek().Undo();
        _commands.Pop();
    }

}