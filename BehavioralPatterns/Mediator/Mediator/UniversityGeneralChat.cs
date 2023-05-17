using Mediator.Components;

namespace Mediator.Mediator;

internal class UniversityGeneralChat: IUniversityChat
{
    private readonly List<User> _users = new();

    public void Register(User user)
    {
        user.SetChat(this);
        _users.Add(user);
    }
        
    public void Send(string from, string message)
    {
        _users.ForEach(u => 
            { if(u.Name != from) u.Receive(from, message); });
    }

    public void SendTo<T>(string from, string message) where T : User
    {
        _users.OfType<T>()
            .ToList()
            .ForEach(u =>
            {
                if (u.Name != from)
                    u.Receive(from, message);
            });
    }

    public void RegisterUsers(params User[] users) 
        => users.ToList().ForEach(Register);
}