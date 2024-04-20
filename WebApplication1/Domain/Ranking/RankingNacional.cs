using WebApplication1.Shared;

namespace WebApplication1.Domain.RankingNacional;

public class RankingNacional:IValueObject
{
    public bool BoolRanking { get; set; }

    public RankingNacional()
    {
        
    }

    public RankingNacional(bool ranking)
    {
        BoolRanking = ranking;
    }
}