using WebApplication1.Shared;

namespace WebApplication1.Domain.Ranking;

public class RankingNome : IValueObject
{
    public string NomeRanking { get; set; }

    public RankingNome()
    {
        
    }

    public RankingNome(string nomeRanking)
    {
        NomeRanking = nomeRanking;
    }
}