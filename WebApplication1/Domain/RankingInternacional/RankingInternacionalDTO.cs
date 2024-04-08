namespace WebApplication1.Domain.RankingInternacional;

public class RankingInternacionalDTO
{
    public Guid Id;
    public string PosicaoRankingInternacional;
    public string NomeRankingInternacional;

    public RankingInternacionalDTO(Guid id, string posicaoRankingInternacional, string nomeRankingInternacional)
    {
        Id = id;
        PosicaoRankingInternacional = posicaoRankingInternacional;
        NomeRankingInternacional = nomeRankingInternacional;
    }
}