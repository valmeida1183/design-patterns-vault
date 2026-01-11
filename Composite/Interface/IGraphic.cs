namespace Composite.Interface;
public interface IGraphic
{
    void Move(int x, int y);
    void Draw(int sub);

    bool IsComposite { get; }
}
