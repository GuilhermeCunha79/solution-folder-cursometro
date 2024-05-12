using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngresso : Entity<Identifier>
{
    public IngressoBool IngressoBool { get; set; }
    public Utilizador_ExameIngressoNotaExame ExameIngressoNotaExame { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Identifier ExameIngressoCodigo { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public ExameIngresso.ExameIngresso ExameIngresso { get; set; }

    public Utilizador_ExameIngresso()
    {
        
    }

    public Utilizador_ExameIngresso(string idUtilizador, string exameCodigo, int notaExame, bool isIngresso)
    {
        UtilizadorId = new Identifier(idUtilizador);
        ExameIngressoCodigo = new ExameIngressoCodigo(exameCodigo).CodigoExameIngresso;
        ExameIngressoNotaExame = new Utilizador_ExameIngressoNotaExame(notaExame);
        IngressoBool = new IngressoBool(isIngresso);
    }
}