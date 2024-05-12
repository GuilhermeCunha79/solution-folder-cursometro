using WebApplication1.Domain.Instituicao;
using WebApplication1.Domain.RankingNacional;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Ranking;

public class Instituicao_Ranking:Entity<Identifier>
{
    public Identifier IdRanking { get; set; }
    public Identifier InstituicaoCodigo { get; set; }

    public Ranking Ranking { get; set; }
    public Instituicao.Instituicao Instituicao { get; set; }

    public Instituicao_Ranking()
    {
        
    }

    public Instituicao_Ranking(int idRanking, int codigo)
    {
        IdRanking = new Identifier(idRanking);
        InstituicaoCodigo = new InstituicaoCodigo(codigo).Codigo;
    }
}