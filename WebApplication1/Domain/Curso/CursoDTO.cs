namespace WebApplication1.Domain.Curso;

public class CursoDTO
{
    public Guid Id;
    public string CodigoCurso;
    public string NomeCurso;

    public CursoDTO(Guid id, string codigoCurso, string nomeCurso)
    {
        Id = id;
        CodigoCurso = codigoCurso;
        NomeCurso = nomeCurso;
    }
}