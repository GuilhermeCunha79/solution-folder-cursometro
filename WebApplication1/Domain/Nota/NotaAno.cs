using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class NotaAno : IValueObject
{
    public int AnoNota { get; set; }

    public NotaAno()
    {
        
    }

    public NotaAno(int ano)
    {
        AnoNota = ano;
    }
}