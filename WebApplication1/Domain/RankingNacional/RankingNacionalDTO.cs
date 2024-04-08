namespace WebApplication1.Domain.RankingNacional;

public class RankingNacionalDTO
{
    public Guid Id;
    public string PosicaoRankingNacional;
    public string NomeRankingNacional;

    public RankingNacionalDTO(Guid id, string posicaoRankingNacional, string nomeRankingNacional)
    {
        Id = id;
        PosicaoRankingNacional = posicaoRankingNacional;
        NomeRankingNacional = nomeRankingNacional;
    }
}