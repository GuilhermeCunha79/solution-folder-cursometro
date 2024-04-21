using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorIdade:IValueObject
{
    
    public int IdadeUtilizador { get; set; }


    public UtilizadorIdade()
    {
        
    }

    public UtilizadorIdade(int idade)
    {
        IdadeUtilizador = idade;
    }
}