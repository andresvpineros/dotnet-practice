namespace dotnet_practice.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Phone { get; set; }
    public string Email { get; set; }
    public string EmailConfirmed { get; set; }
    public string Password { get; set; }
    public string PasswordConfirmed { get; set; }
    public RoleClass Role { get; set; } = RoleClass.Client;

    public User (
        string name,
        string phone,
        string email,
        string emailConfirmed,
        string password,
        string passwordConfirmed,
        RoleClass role)
    {
        Name = name;
        Phone = phone;
        Email = email;
        EmailConfirmed = emailConfirmed;
        Password = password;
        PasswordConfirmed = passwordConfirmed;
        Role = role;
    }
}
