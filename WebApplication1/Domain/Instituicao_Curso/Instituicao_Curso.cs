using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Curso;

public class Instituicao_Curso: Entity<Identifier>
{
    public Instituicao_CursoCodigo InstituicaoCursoCodigo;
    //pk, junção de duas fk
    public InstituicaoCodigo InstituicaoCodigo;
    public CursoCodigo CursoCodigo;
    //Instituicao_Curso
    public Instituicao_CursoECTS InstituicaoCursoEcts;
    public Instituicao_CursoDuracao InstituicaoCursoDuracao;
    public Instituicao_CursoGrau InstituicaoCursoGrau;
    //atributos estrangeiros
    public Identifier CandidaturaIdentifier;
    public Identifier CodigoExame;

    public Instituicao_Curso()
    {
        
    }

    public Instituicao_Curso(string instituicaoCodigo, string cursoCodigo, string ects, string duracao, string grau,
        string candidaturaId, string codigoExame)
    {
        Id = new Identifier(Guid.NewGuid());
        InstituicaoCursoCodigo = new Instituicao_CursoCodigo(instituicaoCodigo, cursoCodigo);
        InstituicaoCursoEcts = new Instituicao_CursoECTS(ects);
        InstituicaoCursoDuracao = new Instituicao_CursoDuracao(duracao);
        InstituicaoCursoGrau = new Instituicao_CursoGrau(grau);
        CandidaturaIdentifier = new Identifier(candidaturaId);
        CodigoExame = new Identifier(codigoExame);
    }
}