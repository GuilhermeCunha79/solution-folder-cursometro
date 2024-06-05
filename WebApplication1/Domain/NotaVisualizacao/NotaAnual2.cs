using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaAnual2:IValueObject
{
    public Identifier IdNotaAnual2 { get; set; }
    public int NotaAnual2DecimoSeg { get; set; }

    public NotaAnual2()
    {
        
    }

    public NotaAnual2(int idNotaAnual2, int notaAnual2DecimoSeg)
    {
        IdNotaAnual2 = new Identifier(idNotaAnual2);
        NotaAnual2DecimoSeg = notaAnual2DecimoSeg;
    }
}