namespace LactFree.User;

public class UserModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool EmailVerified { get; set; }
    public string Password { get; set; }
    public string PasswordHash { get; set; }

}
