using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoLogo : IValueObject
{

    public byte[] Logo { get; set; }

    public InstituicaoLogo()
    {
        
    }

    public InstituicaoLogo(byte[] logo)
    {
        Logo = logo;
    }
}