using Facade.Abstract;

namespace Facade.Services;

public class PaymentService : IPaymentService
{
    public void ProcessPayment(float amount)
    {
        Console.WriteLine("Plata în valoare de " + amount + " a fost procesată cu succes.");
    }
}