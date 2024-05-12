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
    public Identifier IdInformacoes { get; set; }

    public Candidatura()
    {
        
    }

    public Candidatura(int ano, int fase)
    {
        CandidaturaAno = new CandidaturaAno(ano);
        CandidaturaFase = new CandidaturaFase(fase);
    }
}