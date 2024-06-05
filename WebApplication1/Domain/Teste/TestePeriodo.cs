using WebApplication1.Shared;

namespace WebApplication1.Domain.Teste;

public class TestePeriodo:IValueObject
{
    public int PeriodoTeste { get; set; }

    public TestePeriodo()
    {
        
    }

    public TestePeriodo(int periodoTeste)
    {
        PeriodoTeste = periodoTeste;
    }
}