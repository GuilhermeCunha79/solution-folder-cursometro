using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class VagasNumero:IValueObject
{

    public int NumeroVagas { get; set; }

    public VagasNumero()
    {
        
    }

    public VagasNumero(int numeroVagas)
    {
        NumeroVagas = numeroVagas;
    }
}