using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCalculator.Services.Interfaces
{
    public interface ICalculatorService
    {
        double ProcessExpression(StringBuilder expression)
        {
            double result = 0;
            return result;
        }
    }
}
