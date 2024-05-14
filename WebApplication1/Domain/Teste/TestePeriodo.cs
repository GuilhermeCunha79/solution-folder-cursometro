using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Teste;

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