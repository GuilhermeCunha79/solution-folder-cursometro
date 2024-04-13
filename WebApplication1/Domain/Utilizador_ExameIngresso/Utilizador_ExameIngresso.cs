using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngresso : Entity<Identifier>
{
    public Utilizador_ExameIngressoNotaExame ExameIngressoNotaExame { get; set; }

    public ExameIngressoCodigo ExameIngressoCodigo { get; set; }

    public Utilizador_ExameIngresso()
    {
        
    }

    public Utilizador_ExameIngresso(string exameCodigo, string notaExame)
    {
        Id = new Identifier(Guid.NewGuid());
        ExameIngressoCodigo = new ExameIngressoCodigo(exameCodigo);
        ExameIngressoNotaExame = new Utilizador_ExameIngressoNotaExame(notaExame);
    }
}