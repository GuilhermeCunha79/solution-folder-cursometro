using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso_ExameIngresso;

public class NotaExame:IValueObject
{
    public int ExameNota { get; set; }

    public NotaExame()
    {
        
    }

    public NotaExame(int exameNota)
    {
        ExameNota = exameNota;
    }
}