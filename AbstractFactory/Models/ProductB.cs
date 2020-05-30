using AbstractFactory.Abstracts;
using System;

namespace AbstractFactory.Models
{
    public class ProductB : IAbstractProductB
    {
        public string FunctionB()
        {
            return "This function runs from product B";
        }

        public void MethodB()
        {
            Console.WriteLine("This method runs from product B");
        }
    }
}
