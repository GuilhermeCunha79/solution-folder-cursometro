using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso_Tags;

public class Curso_TagsDTO
{
    public Identifier Id;
    public Identifier IdTag;
    public Identifier CodigoCurso;

    public Curso_TagsDTO(Identifier id, Identifier idTag, Identifier codigoCurso)
    {
        Id = id;
        IdTag = idTag;
        CodigoCurso = codigoCurso;
    }
}