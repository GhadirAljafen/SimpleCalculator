

namespace CalculatorManager
{
    public class AgeCalculator : Subtract
    {

       
            // overloading
            public int CurrentYear { set; get; }
            public int BornYear { set; get; }

            public static double Substract(int resultValue, int number)
            {
                return resultValue - number;
            }
    }
}
