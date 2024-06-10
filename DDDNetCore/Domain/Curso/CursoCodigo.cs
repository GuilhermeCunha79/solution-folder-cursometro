using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class CursoCodigo:IValueObject
{
    public Identifier CodigoCurso { get; set; }

    public CursoCodigo()
    {
        
    }

    public CursoCodigo(string codigoCurso)
    {
        CodigoCurso = new Identifier(codigoCurso);
    }
}