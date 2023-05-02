using Facade.Abstract;

namespace Facade.Services;

public class SubscriptionService: ISubscriptionService
{
    private List<string> _subscriptions;

    public SubscriptionService()
    {
        _subscriptions = new List<string>();
    }

    public bool AddSubscription(string subscriptionType)
    {
        _subscriptions.Add(subscriptionType);
        Console.WriteLine("Abonamentul " + subscriptionType + " a fost adăugat cu succes.");
        return true;
    }

    public bool CancelSubscription(string subscriptionType)
    {
        if (_subscriptions.Contains(subscriptionType))
        {
            _subscriptions.Remove(subscriptionType);
            Console.WriteLine("Abonamentul " + subscriptionType + " a fost anulat cu succes.");
            return true;
        }
        else
        {
            Console.WriteLine("Abonamentul " + subscriptionType + " nu a fost găsit.");
            return false;
        }
    }

    public List<string> GetSubscriptions()
    {
        Console.WriteLine("Abonamentele curente sunt:");
        foreach (string subscription in _subscriptions)
        {
            Console.WriteLine("- " + subscription);
        }
        return _subscriptions;
    }
}