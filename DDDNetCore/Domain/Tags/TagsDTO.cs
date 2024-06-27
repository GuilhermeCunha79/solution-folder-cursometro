namespace WebApplication1.Domain.Tags;

public class TagsDTO
{
    public int Id;
    public string Nome;
    public string Descricao;

    public TagsDTO(int id, string nome, string descricao)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
    }
}