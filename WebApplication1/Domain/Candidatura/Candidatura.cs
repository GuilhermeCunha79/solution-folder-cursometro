using WebApplication1.Shared;


namespace WebApplication1.Domain.Candidatura;

public class Candidatura:Entity<Identifier>
{
    public Identifier NotaEntradaId;
    public Identifier VagasId;

    public Candidatura()
    {
        
    }

    public Candidatura(string notaEntradaId,string vagasId)
    {
        Id = new Identifier(Guid.NewGuid());
        NotaEntradaId = new Identifier(notaEntradaId);
        VagasId = new Identifier(vagasId);
    }
}