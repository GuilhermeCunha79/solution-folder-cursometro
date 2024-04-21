namespace WebApplication1.Domain.Instituicao_Ranking;

public class Instituicao_RankingDTO
{
    public Guid IdRanking;
    public Guid CodigoInstituicao;

    public Instituicao_RankingDTO(Guid idRanking, Guid codigoInstituicao)
    {
        IdRanking = idRanking;
        CodigoInstituicao = codigoInstituicao;
    }
}