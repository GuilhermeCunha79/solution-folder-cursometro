namespace WebApplication1.Domain.Tags;

public class TagsDTO
{
    public Guid Id;
    public string Nome;
    public string Descricao;

    public TagsDTO(Guid id, string nome, string descricao)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
    }
}