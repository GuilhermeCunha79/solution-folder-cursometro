using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioNota:IValueObject
{
    public string NotaDecimo { get; set; }
    public string NotaDecimoPrim { get; set; }
    public string NotaDecimoSeg { get; set; }

    public Disciplina_CursoSecundarioNota()
    {
        
    }

    public Disciplina_CursoSecundarioNota(string notaDecimo,string notaDecimoPrim,string notaDecimoSeg)
    {
        NotaDecimo = notaDecimo;
        NotaDecimoPrim = notaDecimoPrim;
        NotaDecimoSeg = notaDecimoSeg;
    }
}
