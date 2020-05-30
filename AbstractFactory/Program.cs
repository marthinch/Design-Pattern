using AbstractFactory.Clients;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new ProductClient().Run();
        }
    }
}
