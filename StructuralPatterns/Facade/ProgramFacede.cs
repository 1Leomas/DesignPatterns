using Facade;

SubscriptionFacade subscriptionFacade = new SubscriptionFacade();


subscriptionFacade.Subscribe("Lunar", 50);

Console.WriteLine();
subscriptionFacade.GetSubscriptions();

Console.WriteLine();
subscriptionFacade.Unsubscribe("Lunar");

Console.WriteLine();
subscriptionFacade.GetSubscriptions();