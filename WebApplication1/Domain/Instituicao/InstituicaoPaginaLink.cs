using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoPaginaLink : IValueObject
{
    public string LinkInstituicao { get; set; }

    public InstituicaoPaginaLink()
    {
        
    }

    public InstituicaoPaginaLink(string linkInstituicao)
    {
        LinkInstituicao = linkInstituicao;
    }
}