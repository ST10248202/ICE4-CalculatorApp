using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Calculator
    {
        public event EventHandler<string> OperationPerformed;

        public double Add(double x, double y)
        {
            double result = x + y;
            OnOperationPerformed($"{x} + {y} = {result}");
            return result;
        }

        public double Subtract(double x, double y)
        {
            double result = x - y;
            OnOperationPerformed($"{x} - {y} = {result}");
            return result;
        }

        public double Multiply(double x, double y)
        {
            double result = x * y;
            OnOperationPerformed($"{x} * {y} = {result}");
            return result;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            double result = x / y;
            OnOperationPerformed($"{x} / {y} = {result}");
            return result;
        }

        protected virtual void OnOperationPerformed(string operation)
        {
            OperationPerformed?.Invoke(this, operation);
        }
    }
}
