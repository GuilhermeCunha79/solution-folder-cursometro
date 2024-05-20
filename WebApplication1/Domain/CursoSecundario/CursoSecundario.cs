using WebApplication1.Shared;

namespace ConsoleApp1.Domain.CursoSecundario;

public class CursoSecundario : Entity<Identifier>
{
    public Identifier CursoSecundarioCodigo { get; set; }
    public CursoSecundarioNome CursoSecundarioNome { get; set; }
    public ICollection<Disciplina_CursoSecundario.Disciplina_CursoSecundario> Disciplina_CursoSecundario { get; set; }

    public CursoSecundario()
    {
        
    }

    public CursoSecundario(string codigo, string nomeCurso)
    {
        CursoSecundarioCodigo = new CursoSecundarioCodigo(codigo).CodigoCursoSecundario;
        CursoSecundarioNome = new CursoSecundarioNome(nomeCurso);
    }
}
