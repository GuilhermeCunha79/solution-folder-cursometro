using WebApplication1.Shared;

namespace WebApplication1.Domain.Distrito;

public class DistritoNome:IValueObject
{
    public string NomeDistrito { get; set; }

    public DistritoNome()
    {
        
    }

    public DistritoNome(string nomeDistrito)
    {
        NomeDistrito = nomeDistrito;
    }
}