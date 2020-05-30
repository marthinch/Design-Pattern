using FactoryMethod.Clients;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new LogisticClient().Run();
        }
    }
}
