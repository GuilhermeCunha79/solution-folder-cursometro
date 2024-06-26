namespace WebApplication1.Domain.Instituicao_Tags;

public class Instituicao_TagsDTO
{
    public int Id;
    public int IdTag;
    public string CodigoInstituicao;

    public Instituicao_TagsDTO(int id, int idTag, string codigoInstituicao)
    {
        Id = id;
        IdTag = idTag;
        CodigoInstituicao = codigoInstituicao;
    }
}