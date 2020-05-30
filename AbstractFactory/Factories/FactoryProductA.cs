using AbstractFactory.Abstracts;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class FactoryProductA : IAbstractFactoryProductA
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA();
        }
    }
}
