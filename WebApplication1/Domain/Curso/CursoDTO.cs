using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class CursoDTO
{
    public string CodigoCurso;
    public string NomeCurso;

    public CursoDTO(string codigoCurso, string nomeCurso)
    {
        CodigoCurso = codigoCurso;
        NomeCurso = nomeCurso;
    }
}