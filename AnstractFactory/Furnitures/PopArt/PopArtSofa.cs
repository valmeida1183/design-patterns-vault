using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.PopArt;
public class PopArtSofa : ISofa
{
    public bool hasCushions()
    {
        return true;
    }
    public void lieOn()
    {
        Console.WriteLine("Lying on a pop art sofa.");
    }
{
}
