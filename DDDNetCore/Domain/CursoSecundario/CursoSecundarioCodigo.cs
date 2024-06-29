using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundarioCodigo : IValueObject
{
    public Identifier CodigoCursoSecundario { get; set; }

    public CursoSecundarioCodigo()
    {
    }

    public CursoSecundarioCodigo(string codigo)
    {
        CodigoCursoSecundario = new Identifier(codigo);
    }
}