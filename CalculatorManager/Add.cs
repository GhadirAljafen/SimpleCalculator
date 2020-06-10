
namespace CalculatorManager
{
    public class Add : IArthimaticOperation
    {
        public double DoOperation(double resultValue,double numbers)
        {
            return resultValue + numbers;
        }
    }
}
