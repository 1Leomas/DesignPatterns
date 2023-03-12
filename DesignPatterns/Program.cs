

var user = new User();
user.Name = "Test";
user.Email = "Email";

var userList = new List<User>();

userList.Add(user);

foreach (var u in userList)
{
    Console.WriteLine("Name: {0}", u.Name);
    Console.WriteLine("Email: {0}", u.Email);
    Console.WriteLine();
}

class User
{
    public string Name = string.Empty;
    public string Email = string.Empty;
}

