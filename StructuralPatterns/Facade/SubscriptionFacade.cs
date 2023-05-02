using Facade.Abstract;
using Facade.Services;

namespace Facade;

public class SubscriptionFacade
{
    private IPaymentService _paymentService;
    private ISubscriptionService _subscriptionService;

    public SubscriptionFacade()
    {
        _paymentService = new PaymentService();
        _subscriptionService = new SubscriptionService();
    }

    public bool Subscribe(string subscriptionType, float amount)
    {
        _paymentService.ProcessPayment(amount);
        return _subscriptionService.AddSubscription(subscriptionType);
    }

    public bool Unsubscribe(string subscriptionType)
    {
        return _subscriptionService.CancelSubscription(subscriptionType);
    }

    public List<string> GetSubscriptions()
    {
        return _subscriptionService.GetSubscriptions();
    }
}