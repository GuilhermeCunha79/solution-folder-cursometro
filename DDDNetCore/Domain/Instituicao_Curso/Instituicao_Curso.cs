using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_Curso : Entity<Identifier>
{
    //pk, junção de duas fk
    public InstituicaoCodigo InstituicaoCodigo { get; set; }

    public CursoCodigo CursoCodigo { get; set; }

    //Instituicao_Curso
    public Instituicao_CursoECTS InstituicaoCursoEcts { get; set; }
    public Instituicao_CursoDuracao InstituicaoCursoDuracao { get; set; }
    public Instituicao_CursoGrau InstituicaoCursoGrau { get; set; }
    public InstituicaoArea InstituicaoArea { get; set; }

    //atributos estrangeiros
    public ICollection<Candidatura.Candidatura> Candidaturas { get; set; }

    public ICollection<Instituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso> Instituicao_Curso_ExameIngressos
    {
        get;
        set;
    }

    public ICollection<Favoritos.Favoritos> Favoritos { get; set; }
    public Instituicao.Instituicao Instituicao { get; set; }
    public Curso.Curso Curso { get; set; }

    public bool Active { get; set; }

    public Instituicao_Curso()
    {
    }

    public Instituicao_Curso(string instituicaoCodigo, string cursoCodigo, string ects, string duracao, string grau,
        string area)
    {
        Id = new Instituicao_CursoCodigo(instituicaoCodigo, cursoCodigo).Codigo;
        InstituicaoCursoEcts = new Instituicao_CursoECTS(ects);
        InstituicaoCursoDuracao = new Instituicao_CursoDuracao(duracao);
        InstituicaoCursoGrau = new Instituicao_CursoGrau(grau);
        InstituicaoArea = new InstituicaoArea(area);
        InstituicaoCodigo = new InstituicaoCodigo(instituicaoCodigo);
        CursoCodigo = new CursoCodigo(cursoCodigo);
        Active = true;
    }

    public void MarkAsInactive()
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "A Instituicao_Curso selecionada já se encontra inativa.");
        Active = false;
    }
}