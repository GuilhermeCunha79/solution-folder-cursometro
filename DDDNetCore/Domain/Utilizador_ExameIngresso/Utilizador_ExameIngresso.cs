using WebApplication1.Domain.Disciplina_CursoSecundario;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngresso : Entity<Identifier>
{
    public Disciplina_CursoIngressoBool DisciplinaCursoIngressoBool { get; set; }
    public Disciplina_CursoNotaExame Exame { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Identifier ExameIngressoCodigo { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public ExameIngresso.ExameIngresso ExameIngresso { get; set; }

    public Utilizador_ExameIngresso()
    {
        
    }

    public Utilizador_ExameIngresso(string idUtilizador, string exameCodigo, string notaExame, bool isIngresso)
    {
        UtilizadorId = new Identifier(idUtilizador);
        ExameIngressoCodigo = new ExameIngressoCodigo(exameCodigo).CodigoExameIngresso;
        Exame = new Disciplina_CursoNotaExame(notaExame);
        DisciplinaCursoIngressoBool = new Disciplina_CursoIngressoBool(isIngresso);
    }
}