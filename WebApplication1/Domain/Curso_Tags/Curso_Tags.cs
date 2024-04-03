using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public class Curso_Tags : Entity<Identifier>
{
    public TagID TagId;
    public CursoCodigo CursoCodigo;

    public Curso_Tags()
    {
    }

    public Curso_Tags(string tagId, string codCurso)
    {
        TagId = new TagID(tagId);
        CursoCodigo = new CursoCodigo(codCurso);
    }
}