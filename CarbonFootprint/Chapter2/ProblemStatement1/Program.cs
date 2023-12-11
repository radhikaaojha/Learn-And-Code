using System;

namespace Chapter2.ProblemStatement1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utility dataHolder = new Utility();
            dataHolder.IntegerValue = 10;
            dataHolder.DoubleValue = 20.5;
            dataHolder.StringValue = "hello";

            dataHolder.calculateAndPrintSum(dataHolder.IntegerValue, 5);
            dataHolder.ConvertAndPrintUpperCaseString("world");
        }
    }
}
