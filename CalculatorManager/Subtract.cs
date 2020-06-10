using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorManager
{
    public class Subtract : IArthimaticOperation
    {
        public double DoOperation(double resultValue, double number)
        {
            return resultValue - number;
        }

    }
}
