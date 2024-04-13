using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaAno:IValueObject
{
    public string Ano { get; set; }

    public CandidaturaAno()
    {
        
    }

    public CandidaturaAno(string ano)
    {
        Ano = ano;
    }
    
}