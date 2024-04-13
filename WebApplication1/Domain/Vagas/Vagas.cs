using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class Vagas : Entity<Identifier>
{
    public VagasNumero VagasNumero { get; set; }

    public Vagas()
    {
        
    }
    
    public Vagas(string vagas)
    {
        Id = new Identifier(Guid.NewGuid());
        VagasNumero = new VagasNumero(vagas);
        
    }
}