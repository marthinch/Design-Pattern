using FactoryMethod.Abstracts.Model;
using System;

namespace FactoryMethod.Models
{
    public class RoadLogistic : IDelivery
    {
        public string Category(string logisticCategory)
        {
            return "Logistic category is " + logisticCategory;
        }

        public void Operation()
        {
            Console.WriteLine("Road logistic is operating now");
        }
    }
}
