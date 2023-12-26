using System.Drawing;

namespace SRP.Example1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);
            double area = rectangle.CalculateArea();

            Display display = new Display();
            display.DisplayArea(area);
        }
    }
}
