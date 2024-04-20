using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaFase:IValueObject
{
    
    public int Fase { get; set; }

    public CandidaturaFase()
    {
        
    }

    public CandidaturaFase(int fase)
    {
        Fase = fase;
    }
    
}