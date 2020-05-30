using FactoryMethod.Abstracts.Model;
using FactoryMethod.Creators;
using FactoryMethod.Models;

namespace FactoryMethod.Logistics
{
    public class Sea : Creator
    {
        public override IDelivery DeliveryFactoryMethod()
        {
            return new SeaLogistic();
        }
    }
}
