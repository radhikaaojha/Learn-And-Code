using System;

namespace Chapter2.ProblemStatement1
{
    public class DataHolder
    {
        public int IntegerValue;
        public double DoubleValue;
        public string StringValue;

        public void calculateAndPrintSum(int operand1, int operand2)
        {
            int sum = operand1 + operand2;
            Console.WriteLine("Result: " + sum);
        }

        public void ConvertAndPrintUpperCaseString(string originalString)
        {
            StringValue = originalString.ToUpper();
            Console.WriteLine("Updated String: " + this.StringValue);
        }
    }

    public class Problem1
    {
        public static void Main(string[] args)
        {
            DataHolder dataHolder = new DataHolder();
            dataHolder.IntegerValue = 10;
            dataHolder.DoubleValue = 20.5;
            dataHolder.StringValue = "hello";

            dataHolder.calculateAndPrintSum(dataHolder.IntegerValue, 5);
            dataHolder.ConvertAndPrintUpperCaseString("world");
        }
    }
}
