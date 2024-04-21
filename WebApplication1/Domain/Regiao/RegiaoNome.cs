using WebApplication1.Shared;

namespace WebApplication1.Domain.Regiao;

public class RegiaoNome:IValueObject
{
    public string NomeRegiao { get; set; }

    public RegiaoNome()
    {
        
    }

    public RegiaoNome(string nomeRegiao)
    {
        NomeRegiao = nomeRegiao;
    }
}