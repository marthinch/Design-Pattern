using AbstractFactory.Abstracts;
using AbstractFactory.Abstracts.Factory;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory.Clients
{
    public class ProductClient
    {
        public void Run()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Run factory Product A...");
            ClientMethodA(new FactoryProductA());

            Console.WriteLine();

            Console.WriteLine("Client: Run factory Product B...");
            ClientMethodB(new FactoryProductB());
        }

        private void ClientMethodA(IAbstractFactoryProductA factory)
        {
            var productA = factory.CreateProductA();
            Console.WriteLine(productA.FunctionA());

            Console.WriteLine(productA.FunctionA1());
        }

        private void ClientMethodB(IAbstractFactoryProductB factory)
        {
            var productB = factory.CreateProductB();
            Console.WriteLine(productB.FunctionB());

            productB.MethodB();
        }
    }
}
