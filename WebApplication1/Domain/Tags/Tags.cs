using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class Tags : Entity<Identifier>
{

    public NomeTags NomeTags { get; set; }
    public TagDescricao TagDescricao { get; set; }

    public Curso_Tags.Curso_Tags CursoTags;
    
    public Instituicao_Tags.Instituicao_Tags InstituicaoTags;

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