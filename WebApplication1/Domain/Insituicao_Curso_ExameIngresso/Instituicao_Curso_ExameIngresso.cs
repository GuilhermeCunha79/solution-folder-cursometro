using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Insituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngresso : Entity<Identifier>
{
    public Identifier IdUtilizador { get; set; }
    public ExameIngressoCodigo ExameIngressoCodigo { get; set; }
    public NotaExame NotaExame { get; set; }

    public ICollection<Utilizador.Utilizador> Utilizadores { get; set; }
    public ICollection<ExameIngresso.ExameIngresso> ExamesIngresso { get; set; }

    public Instituicao_Curso_ExameIngresso()
    {
        
    }

    public Instituicao_Curso_ExameIngresso(Guid idUtilizador, string codigoExame, int notaExame)
    {
        Id = new Identifier(Guid.NewGuid());
        IdUtilizador = new Identifier(idUtilizador);
        ExameIngressoCodigo = new ExameIngressoCodigo(codigoExame);
        NotaExame = new NotaExame(notaExame);
    }
}