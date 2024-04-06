using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoAreaCientifica : IValueObject
{

    private string Area { get; set; }

    public InstituicaoAreaCientifica()
    {
        
    }

    public InstituicaoAreaCientifica(string area)
    {
        Area = area;
    }
}