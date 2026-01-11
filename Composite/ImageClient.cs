namespace Composite;
public class ImageClient
{
    public static void Run()
    {
        // Initialize four dots
        var dot1 = new Dot();
        var dot2 = new Dot();
        var dot3 = new Dot();
        var dot4 = new Dot();

        // Initialize two circles
        var circle1 = new Circle();
        var circle2 = new Circle();

        // Initialize a compound graphic
        var compoundGraphic1 = new CompundGraphic();
        compoundGraphic1.Add(dot1);
        compoundGraphic1.Add(circle1);

        // Initialize another compound graphic
        var compoundGraphic2 = new CompundGraphic();
        compoundGraphic2.Add(dot2);
        compoundGraphic2.Add(dot3);
        compoundGraphic2.Add(circle2);

        // Initialize the main compound graphic
        var mainCompoundGraphic = new CompundGraphic();
        mainCompoundGraphic.Add(compoundGraphic1);
        mainCompoundGraphic.Add(compoundGraphic2);
        mainCompoundGraphic.Add(dot4);

        // Draw the main compound graphic
        mainCompoundGraphic.Draw(2);       
    }
}
