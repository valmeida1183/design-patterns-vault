using Composite.Interface;

namespace Composite;
public class CompundGraphic : IGraphic
{
    private readonly List<IGraphic> _graphics = [];

    public bool IsComposite => true;
    public void Add(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void Remove(IGraphic graphic)
    {
        _graphics.Remove(graphic);
    }

    public void Draw(int sub)
    {
        Console.WriteLine($"{new string('-', sub)} Drawing a Compound Graphic that contians:");

        foreach (var graphic in _graphics)
        {
            graphic.Draw(sub + 2);
        }
    }
    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving a Compound Graphic by {x} horizontally and {y} vertically that contains:");

        foreach (var graphic in _graphics)
        {
            graphic.Move(x, y);
        }
    }
}
