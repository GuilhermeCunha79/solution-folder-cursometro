using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class InstituicaoArea:IValueObject
{
    public string AreaInstituicao { get; set; }

    public InstituicaoArea()
    {
        
    }

    public InstituicaoArea(string area)
    {
        AreaInstituicao = area;
    }
}