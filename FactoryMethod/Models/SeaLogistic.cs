using FactoryMethod.Abstracts.Model;
using System;

namespace FactoryMethod.Models
{
    public class SeaLogistic : IDelivery
    {
        public string Category(string logisticCategory)
        {
            return "Logistic category is " + logisticCategory;
        }

        public void Operation()
        {
            Console.WriteLine("Sea logistic is operating now");
        }
    }
}
