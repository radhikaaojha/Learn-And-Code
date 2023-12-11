using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.ProblemStatement1
{
    public class UtilityClass
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
}
