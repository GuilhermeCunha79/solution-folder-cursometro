namespace WebApplication1.Domain.Instituicao_Ranking;

public class Instituicao_RankingDTO
{
    public int IdRanking;
    public string CodigoInstituicao;

    public Instituicao_RankingDTO(int idRanking, string codigoInstituicao)
    {
        IdRanking = idRanking;
        CodigoInstituicao = codigoInstituicao;
    }
}