using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_Curso:Entity<Identifier>
{
    //pk, junção de duas fk
    public Identifier InstituicaoCodigo{ get; set; }
    public Identifier CursoCodigo{ get; set; }
    //Instituicao_Curso
    public Instituicao_CursoECTS InstituicaoCursoEcts{ get; set; }
    public Instituicao_CursoDuracao InstituicaoCursoDuracao{ get; set; }
    public Instituicao_CursoGrau InstituicaoCursoGrau{ get; set; }

    public InstituicaoArea InstituicaoArea { get; set; }

    //atributos estrangeiros
    public ICollection<Candidatura.Candidatura> Candidaturas { get; set; }
    public ICollection<Instituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso> Instituicao_Curso_ExameIngressos { get; set; }
    public ICollection<Favoritos.Favoritos> Favoritos { get; set; }
    public Instituicao.Instituicao Instituicao { get; set; }
    public Curso.Curso Curso { get; set; }

    public Instituicao_Curso()
    {
        
    }

    public Instituicao_Curso(int instituicaoCodigo, string cursoCodigo, string ects, string duracao, string grau,
        string area)
    {
        Id = new Instituicao_CursoCodigo(instituicaoCodigo, cursoCodigo).Codigo;
        InstituicaoCursoEcts = new Instituicao_CursoECTS(ects);
        InstituicaoCursoDuracao = new Instituicao_CursoDuracao(duracao);
        InstituicaoCursoGrau = new Instituicao_CursoGrau(grau);
        InstituicaoArea = new InstituicaoArea(area);
    }
}