using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngresso: Entity<Identifier>
{
    public ExameIngressoCodigo ExameIngressoCodigo;
    public ExameIngressoNome ExameIngressoNome;

    public ICollection<Calculo_ExameIngresso.Calculo_ExameIngresso> CalculoExameIngresso { get; set; }

    public ExameIngresso()
    {
        
    }

    public ExameIngresso(string codigo, string nome)
    {
        Id = new Identifier(Guid.NewGuid());
        ExameIngressoCodigo = new ExameIngressoCodigo(codigo);
        ExameIngressoNome = new ExameIngressoNome(nome);
    }
}