using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public class Escola:Entity<Identifier>
{
    public EscolaNome EscolaNome { get; set; }
    public Identifier DistritoId { get; set; }
    public Distrito.Distrito Distrito { get; set; }
    public Regiao.Regiao Regiao { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }

    public Escola()
    {
        
    }

    public Escola(int idEscola, string nomeEscola, int idDistrito, string idRegiao)
    {
        Id = new Identifier(idEscola);
        EscolaNome = new EscolaNome(nomeEscola);
        DistritoId = new Identifier(idDistrito);
    }
}