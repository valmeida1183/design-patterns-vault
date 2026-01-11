using Composite.Interface;

namespace Composite;

// Leaf
public class Circle : IGraphic
{
    public bool IsComposite => false;

    public void Draw(int sub)
    {
        Console.WriteLine($"{new string('-', sub)} A Circle was drawn");
    }

    public void Move(int x, int y)
    {
       Console.WriteLine($"A Circle was moved {x} horizontally and {y} vertically");
    }
}
