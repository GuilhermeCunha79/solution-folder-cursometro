using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaAnual1:IValueObject
{
    public Identifier IdNotaAnual1 { get; set; }
    public int NotaAnual1DecimoSeg { get; set; }

    public NotaAnual1()
    {
        
    }

    public NotaAnual1(int idNotaAnual, int notaAnual1DecimoSeg)
    {
        IdNotaAnual1 = new Identifier(idNotaAnual);
        NotaAnual1DecimoSeg = notaAnual1DecimoSeg;
    }
}