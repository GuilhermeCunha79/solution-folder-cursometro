using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class Tags : Entity<Identifier>
{

    public NomeTags NomeTags;
    public TagDescricao TagDescricao;

    public Tags()
    {
        
    }

    public Tags(string id, string nomeTags, string descricao)
    {
        Id = new Identifier(Guid.NewGuid());
        NomeTags = new NomeTags(nomeTags);
        TagDescricao = new TagDescricao(descricao);
    }
}