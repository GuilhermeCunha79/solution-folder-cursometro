namespace WebApplication1.Domain.Ranking;

public class RankingDTO
{
    public int Id;
    public string PosicaoRankingNacional;
    public string NomeRankingNacional;

    public RankingDTO(int id, string posicaoRankingNacional, string nomeRankingNacional)
    {
        Id = id;
        PosicaoRankingNacional = posicaoRankingNacional;
        NomeRankingNacional = nomeRankingNacional;
    }
}