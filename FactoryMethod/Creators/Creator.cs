using FactoryMethod.Abstracts.Model;
using System;

namespace FactoryMethod.Creators
{
    public abstract class Creator
    {
        public abstract IDelivery DeliveryFactoryMethod();
    }
}
