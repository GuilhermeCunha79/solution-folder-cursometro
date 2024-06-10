using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorAno:IValueObject
{
    public int AnoUtilizador { get; set; }

    public UtilizadorAno()
    {
        
    }

    public UtilizadorAno(int ano)
    {
        AnoUtilizador = ano;
    }
}