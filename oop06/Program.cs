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
            #endregion
        }
    }
}
