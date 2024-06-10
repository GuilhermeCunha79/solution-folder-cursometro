using WebApplication1.Shared;

namespace WebApplication1.Domain.Regiao;

public class Regiao : Entity<Identifier>
{
    public RegiaoNome RegiaoNome { get; set; }
    public Distrito.Distrito Distrito { get; set; }
    
    public Regiao()
    {
        
    }

    public Regiao(string nomeRegiao)
    {
        RegiaoNome = new RegiaoNome(nomeRegiao);
    }
}