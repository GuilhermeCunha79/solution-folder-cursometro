using WebApplication1.Shared;

namespace WebApplication1.Domain.RankingNacional;

public class RankingNacionalPosicaoRanking : IValueObject
{

    private string PosicaoRanking { get; set; }

    public RankingNacionalPosicaoRanking()
    {
        
    }
    
    public RankingNacionalPosicaoRanking(string posicaoRanking)
    {
        PosicaoRanking = posicaoRanking;
    }
}