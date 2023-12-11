using System;

namespace Chapter2.ProblemStatement1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataProcessor dataProcessor = new DataProcessor();
            dataProcessor.IntegerValue = 10;
            dataProcessor.DoubleValue = 20.5;
            dataProcessor.StringValue = "hello";

            dataProcessor.calculateAndPrintSum(dataProcessor.IntegerValue, 5);
            dataProcessor.ConvertAndPrintUpperCaseString("world");
        }
    }
}
