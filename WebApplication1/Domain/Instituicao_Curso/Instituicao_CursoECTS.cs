using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoECTS : IValueObject
{
    private string ECTS { get; set; }

    public Instituicao_CursoECTS()
    {
    }

    public Instituicao_CursoECTS(string ects)
    {
        ECTS = ects;
    }
}