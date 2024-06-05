using WebApplication1.Shared;

namespace WebApplication1.Domain.Ranking;

public class RankingPosicao : IValueObject
{

    public string PosicaoRanking { get; set; }

    public RankingPosicao()
    {
        
    }
    
    public RankingPosicao(string posicaoRanking)
    {
        PosicaoRanking = posicaoRanking;
    }
}