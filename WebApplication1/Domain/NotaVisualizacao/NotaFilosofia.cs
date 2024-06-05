using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

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