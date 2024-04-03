using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoLogo : IValueObject
{

    private string Logo { get; set; }

    public InstituicaoLogo()
    {
        
    }

    public InstituicaoLogo(string logo)
    {
        Logo = logo;
    }
}