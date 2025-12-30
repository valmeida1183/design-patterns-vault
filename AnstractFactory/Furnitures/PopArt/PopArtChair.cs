using AbstractFactory.Furnitures.Interface;

namespace AbstractFactory.Furnitures.PopArt;
public class PopArtChair : IChair
{
    public bool hasLegs()
    {
        return true;
    }

    public void sitOn()
    {
        Console.WriteLine("Sitting on a pop art chair.");
    }
}
