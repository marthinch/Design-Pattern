using AbstractFactory.Abstracts;
using AbstractFactory.Abstracts.Factory;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class FactoryProductB : IAbstractFactoryProductB
    {
        public IAbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}
