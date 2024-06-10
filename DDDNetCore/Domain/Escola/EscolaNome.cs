using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public class EscolaNome : IValueObject
{
    public string NomeEscola { get; set; }

    public EscolaNome()
    {
        
    }

    public EscolaNome(string nomeEscola)
    {
        NomeEscola = nomeEscola;
    }
}