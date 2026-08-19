using System.Numerics;
using static System.Net.WebRequestMethods;

namespace oop06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01 Theoretical Questions
            #region Q1
            //Q1: What is abstraction in OOP?
            //abstraction is one of oop principle which is the process of expose what user need hidding how it implemented
            //How is it different from encapsulation?
            // encapsultion is the process of protecting data and controll validating data
            //Give a real - world example(not from the session) that shows the difference between the two.
            // food delivrey App :
            //abstraction :choose returant , choose food , payment method (without know how app contact with the resturant or the bank)
            // encapsultion : order status , payment data , price of order 
            #endregion

            #region Q2
            //Q2: What is the difference between an abstract class and an interface? Give at least four differences.
            //abstract (can contain fields) interface (cant contain feilds)
            //abstract (can contain constructor) interface (cant contain constructor)
            //abstract (class can inherit from only one abstract) interface (class can implement many interfaces)
            //abstract (represent is-a relation ship) interface (repersent capability)

            //When would you choose one over the other?
            //if roles or capability => interface / identity or shared behavior => abstract class
            #endregion

            #region Q3
            //        Q3: Look at the following code and answer the questions below:

            // public abstract class Appliance
            //        {
            //            public string Brand { get; set; }

            //            protected Appliance(string brand) { Brand = brand; }

            //            public abstract double PowerConsumption();

            //            public virtual string Status() => "Standby";

            //            public string Label() => $"{Brand} - {PowerConsumption()}W";
            //        }

            //        public class WashingMachine : Appliance
            //        {
            //            public WashingMachine(string brand) : base(brand) { }
            //            public override double PowerConsumption() => 500;
            //            public override string Status() => "Washing";
            //        }

            //        public class Toaster : Appliance
            //        {
            //            public Toaster(string brand) : base(brand) { }
            //            public override double PowerConsumption() => 800;
            //        }
            //======================================================================
            //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            // no ,as Appliance is abstract class which cant create an object from it

            //b) What is the difference between the three methods: PowerConsumption(),
            // abstract method as any class inherit from this class must implement it as fit his behavior
            //Status(),
            // virtual method each class inherete this class can overide it to fit his behavior or let it as it is
            //and Label()
            //concerete method which suitable for all classes inherite this class

            //c) If you call Status() on a Toaster object, what will it return? Why?
            //will return stand by as it is a virtual method toaster didnt do override then it will use the base class implementation

            #endregion

            #region Q4

            //Q4: Look at the following code and answer the questions below:

            // File: Calculator.cs
            //public partial class Calculator
            //        {
            //            public double LastResult { get; private set; }
            //            partial void OnCalculated(double result);

            //            public double Add(double a, double b)
            //            {
            //                LastResult = a + b;
            //                OnCalculated(LastResult);
            //                return LastResult;
            //            }
            //        }

            //        // File: Calculator.Logging.cs
            //        public partial class Calculator
            //        {
            //            partial void OnCalculated(double result)
            //            {
            //                Console.WriteLine($"Log: result = {result}");
            //            }
            //        }

            //        // File: DoubleExtensions.cs
            //        public static class DoubleExtensions
            //        {
            //            public static string ToCurrency(this double value)
            //                => $"${value:F2}";


            // =============================================================================================

            //        a) What is a partial class?
//           is the class being splited into more tha one file comopiler read them as one file
            //        Why would a developer split Calculator into two files?
            // team work , large projects , enable code generating , protect manual code 


            //        b) What is a partial method?
            //        method declared in one parial class implemented in another 
            //        What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
            // yes , the compile will remove it as the implementation of pertioa class is optional

            //c) What is an extension method?
            // method we can it ti an existing type with out editing in the source code
            //What are the three rules for writing one?
            // static class - static method - this 1st param

            //d) What will the following code print?
            //Calculator calc = new Calculator();
            //double result = calc.Add(19.5, 0.5);
            //Console.WriteLine(result.ToCurrency());

            // $20.00



            #endregion
            #endregion
        }
    }
}
