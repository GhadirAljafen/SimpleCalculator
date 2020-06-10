
namespace CalculatorManager
{
    class Divide : IArthimaticOperation
    {
        public double DoOperation(double resultValue, double number)
        {
            return resultValue / number;
        }
    }
}
