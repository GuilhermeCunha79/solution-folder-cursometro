using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;


namespace WebApplication1.Domain.Candidatura;

public class Candidatura:Entity<Identifier>
{
    public Identifier NotaEntradaId;
    public Identifier VagasId;
    public CandidaturaAno CandidaturaAno { get; set; }
    public CandidaturaFase CandidaturaFase { get; set; }

    public InformacoesCandidatura.InformacoesCandidatura InformacoesCandidatura { get; set; }
    public Instituicao_CursoCodigo InstituicaoCursoCodigo { get; set; }
    public Identifier IdInformacoes { get; set; }

    public Candidatura()
    {
        
    }

    public Candidatura(string notaEntradaId,string vagasId, int ano, int fase)
    {
        Id = new Identifier(Guid.NewGuid());
        NotaEntradaId = new Identifier(notaEntradaId);
        VagasId = new Identifier(vagasId);
        CandidaturaAno = new CandidaturaAno(ano);
        CandidaturaFase = new CandidaturaFase(fase);
    }
}