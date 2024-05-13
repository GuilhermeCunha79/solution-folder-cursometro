using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class NotaFilosofia:IValueObject
{
    public int NotaFilosofiaDecimo { get; set; }
    public int NotaFilosofiaDecimoPrim { get; set; }

    public NotaFilosofia()
    {
        
    }

    public NotaFilosofia(int notaFilosofiaDecimo, int notaFilosofiaDecimoPrim)
    {
        NotaFilosofiaDecimo = notaFilosofiaDecimo;
        NotaFilosofiaDecimoPrim = notaFilosofiaDecimoPrim;
    }
}