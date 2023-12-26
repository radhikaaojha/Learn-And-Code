using OpenClosedPrinciple;

namespace SolidPrinciple.OCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDeviceFactory smartphoneFactory = new SmartPhoneFactory();
            IDevice smartphone = smartphoneFactory.CreateDevice();
            smartphone.DisplayDetails();

            IDeviceFactory laptopFactory = new LaptopFactory();
            IDevice laptop = laptopFactory.CreateDevice();
            laptop.DisplayDetails();
        }
    }
}