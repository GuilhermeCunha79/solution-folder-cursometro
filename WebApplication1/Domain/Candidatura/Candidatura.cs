using WebApplication1.Shared;


namespace WebApplication1.Domain.Candidatura;

public class Candidatura:Entity<Identifier>
{
    public NotaEntrada.NotaEntrada NotaEntrada;
    public Vagas.Vagas Vagas;

    public Candidatura()
    {
        
    }

    public Candidatura(NotaEntrada.NotaEntrada notaEntrada,Vagas.Vagas vagas)
    {
        Id = new Identifier(Guid.NewGuid());
        NotaEntrada = notaEntrada;
        Vagas = vagas;
    }
}