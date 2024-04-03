using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Curso;

public class Curso : Entity<Identifier>
{
    public CursoCodigo CursoCodigo;
    public CursoNome CursoNome;

    public Curso()
    {
        
    }

    public Curso(string codigoId, string nome)
    {
        
    }

}