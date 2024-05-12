using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class NotaFila:IValueObject
{
    public int FilaNota { get; set; }

    public NotaFila()
    {
        
    }

    public NotaFila(int filaNota)
    {
        FilaNota = filaNota;
    }
}