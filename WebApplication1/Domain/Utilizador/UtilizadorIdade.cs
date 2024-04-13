using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorIdade:IValueObject
{
    
    public string IdadeUtilizador { get; set; }


    public UtilizadorIdade()
    {
        
    }

    public UtilizadorIdade(string idade)
    {
        IdadeUtilizador = idade;
    }
}