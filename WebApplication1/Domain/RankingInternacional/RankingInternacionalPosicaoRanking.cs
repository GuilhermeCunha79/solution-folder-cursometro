using WebApplication1.Shared;

namespace WebApplication1.Domain.RankingInternacional;

public class RankingInternacionalPosicaoRanking : IValueObject
{

    private string PosicaoRanking { get; set; }

    public RankingInternacionalPosicaoRanking()
    {
        
    }
    
    public RankingInternacionalPosicaoRanking(string posicaoRanking)
    {
        PosicaoRanking = posicaoRanking;
    }
}