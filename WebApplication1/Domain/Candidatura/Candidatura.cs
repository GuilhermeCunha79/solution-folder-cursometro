using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class Candidatura:Entity<Identifier>
{
    public CandidaturaAno CandidaturaAno { get; set; }
    public CandidaturaFase CandidaturaFase { get; set; }
    public InformacoesCandidatura.InformacoesCandidatura InformacoesCandidatura { get; set; }
    public Identifier Instituicao_CursoCodigo { get; set; }
    public Instituicao_Curso.Instituicao_Curso InstituicaoCurso { get; set; }

    public Candidatura()
    {
        
    }

    public Candidatura(string instituicaoCursoCodigo,int ano, int fase)
    {
        Instituicao_CursoCodigo = new Instituicao_CursoCodigo(instituicaoCursoCodigo).Codigo;
        CandidaturaAno = new CandidaturaAno(ano);
        CandidaturaFase = new CandidaturaFase(fase);
    }
}