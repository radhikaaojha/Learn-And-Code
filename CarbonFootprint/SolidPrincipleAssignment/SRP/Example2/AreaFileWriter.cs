using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example2
{
    public class AreaFileWriter
    {
        public void WriteAreaToFile(double area)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("area.txt"))
                {
                    writer.Write("Area: " + area);
                }
            }
            catch (IOException e)
            {
                Console.Error.WriteLine("Error writing to file: " + e.Message);
            }
        }
    }
}
