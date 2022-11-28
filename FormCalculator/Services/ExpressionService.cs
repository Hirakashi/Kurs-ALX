using FormCalculator.Services.Interfaces;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCalculator.Services
{
    public class ExpressionService
    {
        static public double ProcessExpresion(string expression)
        {
            expression += "=";
            double result = CreateNumberSubstring(expression);
            return result;
            
        }
        private static double CreateNumberSubstring(string expression)
        {
            List<double> numbers = new List<double>();
            List<char> operations = new List<char>();
            var expressionArray = expression.ToCharArray();
            var numberBuilder = new StringBuilder();
            
            for (int i = 0; i < expressionArray.Length; i++)
            {
                if (Char.IsDigit(expressionArray[i]) || expressionArray[i] == ',')
                {
                    numberBuilder.Append(expressionArray[i]);
                }
                else
                {
                    var number = Convert.ToDouble(numberBuilder.ToString());
                    numberBuilder.Clear();
                    numbers.Add(number);
                    operations.Add(expressionArray[i]);
                }

            }
            double result = PerformOperations(numbers, operations);
            return result;
        }
        private static double PerformOperations(List<double> numbers, List<char> operations)
        {
            var result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }

            return result;
        }
        private static double PerformOperation(char o, double x,  double y)
        {

            switch (o)
            {
                case '+':
                    return x + y;
                    break;
                case '-':
                    return x - y;
                    break;
                case 'x':
                    return x * y;
                    break;
                case '/':
                    return x / y;
                    break;
                default:
                    return x;
            }
        }
        public static bool CheckIfNumberIsLast(string expression)
        {
            if (String.IsNullOrEmpty(expression))
                return false;
            if (Char.IsDigit(expression.Last()))            
                return true;            
            return false;
        }
    }
}
