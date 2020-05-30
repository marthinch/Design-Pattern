using AbstractFactory.Abstracts;

namespace AbstractFactory.Models
{
    public class ProductA : IAbstractProductA
    {
        public string FunctionA()
        {
            return "This function runs from product A";
        }

        public string FunctionA1()
        {
            return "This another function runs from product A";
        }
    }
}
