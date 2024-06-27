namespace WebApplication1.Domain.Ranking;

public class RankingDTO
{
    public int Id;
    public string NomeRanking;
    public string Posicao;
    public bool NacionalBool;

    public RankingDTO(int id,string nome,string posicao, bool nacional)
    {
        Id = id;
        NomeRanking = nome;
        Posicao = posicao;
        NacionalBool = nacional;
    }
}