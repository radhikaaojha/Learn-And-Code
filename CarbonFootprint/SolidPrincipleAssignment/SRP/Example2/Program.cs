using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);
            double area = rectangle.CalculateArea();

            AreaFileWriter areaFileWriter = new AreaFileWriter();
            areaFileWriter.WriteAreaToFile(area);

            Display display = new Display();
            display.DisplayArea(area);

        }
    }
}
