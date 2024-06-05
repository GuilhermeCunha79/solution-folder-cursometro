using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_CursoAreaCientifica : IValueObject
{

    private string Area { get; set; }

    public Instituicao_CursoAreaCientifica()
    {
        
    }

    public Instituicao_CursoAreaCientifica(string area)
    {
        Area = area;
    }
}