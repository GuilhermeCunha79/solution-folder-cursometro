using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaAno:IValueObject
{
    public int Ano { get; set; }

    public CandidaturaAno()
    {
        
    }

    public CandidaturaAno(int ano)
    {
        Ano = ano;
    }
    
}