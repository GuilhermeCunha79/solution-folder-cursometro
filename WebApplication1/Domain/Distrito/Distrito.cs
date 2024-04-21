using WebApplication1.Shared;

namespace WebApplication1.Domain.Distrito;

public class Distrito:Entity<Identifier>
{
    public DistritoNome DistritoNome { get; set; }

    public Escola.Escola Escola { get; set; }

    public Distrito()
    {
        
    }

    public Distrito(string nome)
    {
        Id = new Identifier(nome);
        DistritoNome = new DistritoNome(nome);
    }
}