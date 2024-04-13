using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorNome:IValueObject
{
    
    public string NomeUtilizador { get; set; }

    public UtilizadorNome()
    {
        
    }

    public UtilizadorNome(string nome)
    {
        NomeUtilizador = nome;
    }
}