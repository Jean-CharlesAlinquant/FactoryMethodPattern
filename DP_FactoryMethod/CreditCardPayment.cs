namespace DesignPatterns.Factories.FactoryMethod;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} to merchant using a Credit Card.");
    }
}
