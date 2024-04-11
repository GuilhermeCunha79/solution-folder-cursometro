using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public class Curso_Tags : Entity<Identifier>
{
    public Guid TagId;
    public CursoCodigo CursoCodigo;
    
    public Curso.Curso Curso { get; set; }

    public Curso_Tags()
    {
    }

    public Curso_Tags(Guid tagId, string codCurso)
    {
        TagId = tagId;
        CursoCodigo = new CursoCodigo(codCurso);
    }
}