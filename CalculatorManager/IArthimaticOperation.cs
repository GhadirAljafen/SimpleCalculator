

namespace CalculatorManager
{
public    interface IArthimaticOperation
    {
        double DoOperation(double resultValue, double number);
    }


    //abstract class Animal
    //{
    //    private string Name;

    //    public void SetName(string name) { Name = name; }
    //    public virtual string GetName() { return Name; }

    //    private int NumberOfLegs;
    //    public void SetNumberOfLegs(int numberOfLegs) { NumberOfLegs = numberOfLegs; }
    //    public int GetNumberOfLegs() { return NumberOfLegs; }
    //}

    //class Dog : Animal
    //{
    //    public Dog()
    //    {
    //        SetNumberOfLegs(4);
    //    }

    //    public void DugHole()
    //    {

    //    }

    //    public override string GetName()
    //    {
    //        base.GetName();
    //        return "Puppy";
    //    }
    //}

    //class Hawk: Animal
    //{
    //    public Hawk()
    //    {
    //        SetNumberOfLegs(2);
    //    }
    //    public void Fly()
    //    {
    //        //DO fly
    //    }
    //}

}
