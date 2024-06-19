namespace WebApplication1.Domain.Instituicao_Ranking;

public class Instituicao_RankingDTO
{
    public int Id;
    public int IdRanking;
    public string CodigoInstituicao;

    public Instituicao_RankingDTO(int id,int idRanking, string codigoInstituicao)
    {
        Id = id;
        IdRanking = idRanking;
        CodigoInstituicao = codigoInstituicao;
    }
}