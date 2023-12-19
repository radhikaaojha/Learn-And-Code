using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.ProblemStatement1
{
    public class DataProcessor
    {
        public int Operand;
        public double DoubleValue;
        public string Text;

        public void calculatetSum(int operand1, int operand2)
        {
            int sum = operand1 + operand2;
            Console.WriteLine("Result: " + sum);
        }

        public void ConvertToUpperCase(string inputText)
        {
            Text = inputText.ToUpper();
            Console.WriteLine("Updated String: " + this.Text);
        }
    }
}
