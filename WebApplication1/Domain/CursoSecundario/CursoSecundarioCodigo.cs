using WebApplication1.Shared;

namespace ConsoleApp1.Domain.CursoSecundario;

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