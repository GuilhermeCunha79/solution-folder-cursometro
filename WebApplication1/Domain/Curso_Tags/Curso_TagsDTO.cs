namespace WebApplication1.Domain.Curso_Tags;

public class Curso_TagsDTO
{
    public Guid Id;
    public Guid IdTag;
    public Guid CodigoCurso;

    public Curso_TagsDTO(Guid id, Guid idTag, Guid codigoCurso)
    {
        Id = id;
        IdTag = idTag;
        CodigoCurso = codigoCurso;
    }
}