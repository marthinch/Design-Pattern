using FactoryMethod.Abstracts.Model;
using FactoryMethod.Creators;
using FactoryMethod.Models;

namespace FactoryMethod.Logistics
{
    public class Road : Creator
    {
        public override IDelivery DeliveryFactoryMethod()
        {
            return new RoadLogistic();
        }
    }
}
