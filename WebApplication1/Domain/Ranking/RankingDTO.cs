﻿namespace WebApplication1.Domain.Ranking;

public class RankingDTO
{
    public Guid Id;
    public string PosicaoRankingNacional;
    public string NomeRankingNacional;

    public RankingDTO(Guid id, string posicaoRankingNacional, string nomeRankingNacional)
    {
        Id = id;
        PosicaoRankingNacional = posicaoRankingNacional;
        NomeRankingNacional = nomeRankingNacional;
    }
}