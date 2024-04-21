using WebApplication1.Shared;

namespace WebApplication1.Domain.Regiao;

public class Regiao : Entity<Identifier>
{
    public RegiaoNome RegiaoNome { get; set; }
    public Escola.Escola Escola { get; set; }
    
    public Regiao()
    {
        
    }

    public Regiao(string nomeRegiao)
    {
        Id = new Identifier(Guid.NewGuid());
        RegiaoNome = new RegiaoNome(nomeRegiao);
    }
}