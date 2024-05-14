using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Teste;

public class TesteAno:IValueObject
{
    public int AnoTeste { get; set; }

    public TesteAno()
    {
        
    }
    
    public TesteAno(int anoTeste)
    {
        AnoTeste = anoTeste;
    }
}