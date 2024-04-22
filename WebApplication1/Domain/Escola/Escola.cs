using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public class Escola:Entity<Identifier>
{
    public EscolaNome EscolaNome { get; set; }
    public Identifier IdDistrito { get; set; }
    public Identifier IdRegiao { get; set; }

    public Distrito.Distrito Distrito { get; set; }
    public Regiao.Regiao Regiao { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }

    public Escola()
    {
        
    }

    public Escola(string nomeEscola, string idDistrito, string idRegiao)
    {
        Id = new Identifier(Guid.NewGuid());
        EscolaNome = new EscolaNome(nomeEscola);
        IdDistrito = new Identifier(idDistrito);
        IdRegiao = new Identifier(idRegiao);
    }
}