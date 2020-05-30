namespace FactoryMethod.Abstracts.Model
{
    public interface IDelivery
    {
        string Category(string logisticCategory);
        void Operation();
    }
}
