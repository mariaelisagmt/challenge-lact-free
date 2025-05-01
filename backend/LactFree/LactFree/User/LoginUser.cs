using LactFree.Infraestructure;
using Microsoft.AspNetCore.Identity;

namespace LactFree.User;

public class PasswordHasher //O que essa parte vai ser responsavel de fazer? Senha criptografada?
{
    private readonly string _password;
    public bool Verify(string password, string passwordHash)
    {
        return true;
    }
}
public class LoginUser(string dbcontex, PasswordHasher passwordHasher, TokenProvider tokenProvider)
{
    public sealed record Request(string Email, string Password);

    public async Task<UserModel> Handler(Request request)
    {
        UserModel? user = new UserModel();//consulta do banco de dados via entity framework
        
        if (user is null || user.EmailVerified)
        {
            throw new Exception("The user was not found");
        }

        bool verified = passwordHasher.Verify(request.Password, user.PasswordHash);

        if (!verified)
        {
            throw new Exception("The password is incorrect");
        }

        string token = tokenProvider.Create(user);

        return user;               
    }
}
