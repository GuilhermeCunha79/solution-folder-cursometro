using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoIngressoBool:IValueObject
{
    public bool BoolIngresso { get; set; }

    public Disciplina_CursoIngressoBool()
    {
        
    }

    public Disciplina_CursoIngressoBool(bool boolIngresso)
    {
        BoolIngresso = boolIngresso;
    }
}