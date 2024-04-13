using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador;

public class UtilizadorEscola : IValueObject
{
    public string EscolaUtilizador { get; set; }

    public UtilizadorEscola()
    {
    }

    public UtilizadorEscola(string escola)
    {
        EscolaUtilizador = escola;
    }
}