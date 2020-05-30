using FactoryMethod.Creators;
using FactoryMethod.Logistics;
using System;

namespace FactoryMethod.Clients
{
    public class LogisticClient
    {
        public void Run()
        {
            Console.WriteLine("App: Road Logistic is starting...");
            ClientCode(new Road(), "Door to Port");

            Console.WriteLine("");

            Console.WriteLine("App: Sea Logistic is starting...");
            ClientCode(new Sea(), "Port To Port");
        }

        private void ClientCode(Creator creator, string category)
        {
            Console.WriteLine(creator.DeliveryFactoryMethod().Category(category));

            creator.DeliveryFactoryMethod().Operation();
        }
    }
}
