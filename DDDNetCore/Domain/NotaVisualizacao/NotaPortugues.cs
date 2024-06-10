using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaPortugues:IValueObject
{
    public int NotaPortuguesDecimo { get; set; }
    public int NotaPortuguesDecimoPrim { get; set; }
    public int NotaPortuguesDecimoSeg { get; set; }

    public NotaPortugues()
    {
        
    }

    public NotaPortugues(int notaPortuguesDecimo,int notaPortuguesDecimoPrim, int notaPortuguesDecimoSeg)
    {
        NotaPortuguesDecimo = notaPortuguesDecimo;
        NotaPortuguesDecimoPrim = notaPortuguesDecimoPrim;
        NotaPortuguesDecimoSeg = notaPortuguesDecimoSeg;
    }
}