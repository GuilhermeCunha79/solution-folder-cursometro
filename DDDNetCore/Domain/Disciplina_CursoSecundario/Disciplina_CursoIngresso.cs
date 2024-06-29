
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoIngresso : IValueObject
{
    public bool BoolIngresso { get; set; }

    public Disciplina_CursoIngresso()
    {
    }

    public Disciplina_CursoIngresso(bool boolIngresso)
    {
        BoolIngresso = boolIngresso;
    }
}