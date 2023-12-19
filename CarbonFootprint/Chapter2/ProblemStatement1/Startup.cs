using System;

namespace Chapter2.ProblemStatement1
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            DataProcessor dataProcessor = new DataProcessor();
            dataProcessor.Operand = 10;
            dataProcessor.DoubleValue = 20.5;
            dataProcessor.Text = "hello";

            dataProcessor.calculatetSum(dataProcessor.Operand, 5);
            dataProcessor.ConvertToUpperCase("world");
        }
    }
}
