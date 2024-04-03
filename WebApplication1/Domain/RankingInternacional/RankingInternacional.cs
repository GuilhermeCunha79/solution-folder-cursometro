using WebApplication1.Shared;

namespace WebApplication1.Domain.RankingInternacional;

public class RankingInternacional:Entity<Identifier>
{

    public RankingInternacionalPosicaoRanking PosicaoRanking;

    public RankingInternacional()
    {
        
    }

    public RankingInternacional(string posicao)
    {
        Id = new Identifier(Guid.NewGuid());
        PosicaoRanking = new RankingInternacionalPosicaoRanking(posicao);
    }
}