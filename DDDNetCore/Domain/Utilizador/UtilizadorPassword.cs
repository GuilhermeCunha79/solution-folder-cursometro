using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorPassword : IValueObject
{
    public string Password { get; set; }

    public UtilizadorPassword()
    {
        
    }

    public UtilizadorPassword(string password)
    {
        Password = password;
    }
    
}