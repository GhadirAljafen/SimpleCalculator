
namespace CalculatorManager
{
    public static class ArthimaticFactory
    {

        // - , resultPrev , new number

        public static double Calculate(string operation, double resultValue , double number)
        {
            IArthimaticOperation arthimatic;
            switch (operation)
            {
                case "-":
                    arthimatic = new Subtract();
                    break;
                case "+":
                    arthimatic = new Add();
                    break;
                case "*":
                    arthimatic = new Multiply();
                    break;
                case "/":
                    arthimatic = new Divide();
                    break;
                default:
                    return 0;
            }
            // result , number
            return arthimatic.DoOperation(resultValue,number);
        }
    }
}
