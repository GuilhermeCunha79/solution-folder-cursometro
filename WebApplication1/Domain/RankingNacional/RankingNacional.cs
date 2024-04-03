using WebApplication1.Shared;

namespace WebApplication1.Domain.RankingNacional;

public class RankingNacional : Entity<Identifier>
{
    
    public RankingNacionalPosicaoRanking PosicaoRanking;

    public RankingNacional()
    {
        
    }

    public RankingNacional(string posicao)
    {
        Id = new Identifier(Guid.NewGuid());
        PosicaoRanking = new RankingNacionalPosicaoRanking(posicao);
    }
    
}