using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaFase:IValueObject
{
    
    public string Fase { get; set; }

    public CandidaturaFase()
    {
        
    }

    public CandidaturaFase(string fase)
    {
        Fase = fase;
    }
    
}