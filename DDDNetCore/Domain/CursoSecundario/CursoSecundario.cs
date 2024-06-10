using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundario : Entity<Identifier>
{
    public Identifier CursoSecundarioCodigo { get; set; }
    public CursoSecundarioNome CursoSecundarioNome { get; set; }
    public ICollection<WebApplication1.Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> Disciplina_CursoSecundario { get; set; }
    public bool Active { get; set; }
    
    public CursoSecundario()
    {
        
    }

    public CursoSecundario(int codigo, string nomeCurso)
    {
        CursoSecundarioCodigo = new CursoSecundarioCodigo(codigo).CodigoCursoSecundario;
        CursoSecundarioNome = new CursoSecundarioNome(nomeCurso);
        Active = true;
    }
}
