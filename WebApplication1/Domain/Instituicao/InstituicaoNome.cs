using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoNome : IValueObject
{

    private string Nome { get; set; }

    public InstituicaoNome()
    {
        
    }

    public InstituicaoNome(string nome)
    {
        Nome = nome;
    }
}