using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngressoNome : IValueObject
{
    private string NomeExameIngresso { get; set; }

    public ExameIngressoNome()
    {
        
    }

    public ExameIngressoNome(string nomeExameIngresso)
    {
        NomeExameIngresso = nomeExameIngresso;
    }
    
}