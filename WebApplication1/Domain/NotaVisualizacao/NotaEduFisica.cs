using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaEduFisica:IValueObject
{
    public int NotaEduFisicaDecimo { get; set; }
    public int NotaEduFisicaDecimoPrim { get; set; }
    public int NotaEduFisicaDecimoSeg { get; set; }

    public NotaEduFisica()
    {
        
    }

    public NotaEduFisica(int notaEduFisicaDecimo, int notaEduFisicaDecimoPrim, int notaEduFisicaDecimoSeg)
    {
        NotaEduFisicaDecimo = notaEduFisicaDecimo;
        NotaEduFisicaDecimoPrim = notaEduFisicaDecimoPrim;
        NotaEduFisicaDecimoSeg = notaEduFisicaDecimoSeg;
    }
}