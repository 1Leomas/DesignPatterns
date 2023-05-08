using Mediator.Components;

namespace Mediator.Mediator;

internal interface ICollegeChat 
{
    void Register(User user);
    void Send(string from, string message);
    void SendTo<T>(string from, string message) where T : User;
}   