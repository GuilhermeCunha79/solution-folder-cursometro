﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Ranking;

public class Ranking : Entity<Identifier>
{
    public RankingPosicao Posicao { get; set; }
    public RankingNome RankingNome{ get; set; }
    public RankingNacional RankingNacional { get; set; }

    public ICollection<Instituicao_Ranking.Instituicao_Ranking> InstituicaoRankings { get; set; }
    
    public Ranking()
    {
        
    }

    public Ranking(int idRanking,string nome,string posicao, bool nacional)
    {
        Id = new Identifier(idRanking);
        RankingNome = new RankingNome(nome);
        Posicao = new RankingPosicao(posicao);
        RankingNacional = new RankingNacional(nacional);
    }
    
}