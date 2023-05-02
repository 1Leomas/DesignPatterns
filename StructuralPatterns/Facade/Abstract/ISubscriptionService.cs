namespace Facade.Abstract;

public interface ISubscriptionService
{
    bool AddSubscription(string subscriptionType);
    bool CancelSubscription(string subscriptionType);
    List<string> GetSubscriptions();
}