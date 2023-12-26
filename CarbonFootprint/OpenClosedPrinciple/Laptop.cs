using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Laptop : IDevice
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Laptop: Model Y, RAM: 16GB, Storage: 512GB");
        }
    }
}
