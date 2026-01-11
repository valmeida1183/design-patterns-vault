using Composite.Interface;

namespace Composite;

// Leaf
public class Dot : IGraphic
{
    public bool IsComposite => false;

    public void Draw(int sub)
    {
        Console.WriteLine($"{new string('-', sub)} A Dot was drawn");
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"A Dot was moved {x} horizontally and {y} vertically");
    }
}
