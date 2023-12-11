using System;

namespace Chapter2.ProblemStatement1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UtilityClass dataHolder = new UtilityClass();
            dataHolder.IntegerValue = 10;
            dataHolder.DoubleValue = 20.5;
            dataHolder.StringValue = "hello";

            dataHolder.calculateAndPrintSum(dataHolder.IntegerValue, 5);
            dataHolder.ConvertAndPrintUpperCaseString("world");
        }
    }
}
