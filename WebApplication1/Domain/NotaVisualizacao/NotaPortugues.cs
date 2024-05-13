using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

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