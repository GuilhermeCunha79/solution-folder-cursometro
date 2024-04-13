using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class VagasNumero:IValueObject
{

    public string NumeroVagas { get; set; }

    public VagasNumero()
    {
        
    }

    public VagasNumero(string numeroVagas)
    {
        NumeroVagas = numeroVagas;
    }
}