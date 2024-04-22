using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public class Curso_Tags : Entity<Identifier>
{
    public Identifier TagId { get; set; }
    public CursoCodigo CursoCodigo { get; set; }
    public Curso.Curso Curso { get; set; }
    public Tags.Tags Tags { get; set; }

    public Curso_Tags()
    {
    }

    public Curso_Tags(string tagId, string codCurso)
    {
        TagId = new Identifier(tagId);
        CursoCodigo = new CursoCodigo(codCurso);
    }
}