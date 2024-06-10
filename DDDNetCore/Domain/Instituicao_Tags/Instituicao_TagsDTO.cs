namespace WebApplication1.Domain.Instituicao_Tags;

public class Instituicao_TagsDTO
{
    public Guid Id;
    public Guid IdTag;
    public string CodigoInstituicao;

    public Instituicao_TagsDTO(Guid id, Guid idTag, string codigoInstituicao)
    {
        Id = id;
        IdTag = idTag;
        CodigoInstituicao = codigoInstituicao;
    }
}