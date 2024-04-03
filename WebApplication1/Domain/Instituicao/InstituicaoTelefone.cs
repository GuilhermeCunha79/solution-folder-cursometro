using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoTelefone:IValueObject
{
    private string Telefone { get; set; }

    public InstituicaoTelefone()
    {
        
    }

    public InstituicaoTelefone(string telefone)
    {
        Telefone = telefone;
    }
}