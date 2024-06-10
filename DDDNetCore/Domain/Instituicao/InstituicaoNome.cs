using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoNome : IValueObject
{

    public string Nome { get; set; }

    public InstituicaoNome()
    {
        
    }

    public InstituicaoNome(string nome)
    {
        Nome = nome;
    }
}