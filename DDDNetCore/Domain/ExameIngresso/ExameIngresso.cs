using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngresso : Entity<Identifier>
{
    public ExameIngressoNome ExameIngressoNome { get; set; }

    public ICollection<Instituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso> InstituicaoCursoExameIngressos
    {
        get;
        set;
    }
    
    public ICollection<Disciplina_CursoSecundario.Disciplina_CursoSecundario> DisciplinaCursoSecundarios
    {
        get;
        set;
    }

    public bool Active { get; set; }

    public ExameIngresso()
    {
    }

    public ExameIngresso(string codigo, string nome)
    {
        Id = new ExameIngressoCodigo(codigo).GetCodigoExameIngresso();
        ExameIngressoNome = new ExameIngressoNome(nome);
        Active = true;
    }
}