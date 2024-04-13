using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Tags;

public class Instituicao_Tags:Entity<Identifier>
{
    public Identifier TagId { get; set; }
    public InstituicaoCodigo InstituicaoCodigo { get; set; }

    public Tags.Tags Tags { get; set; }


    public Instituicao_Tags()
    {
        
    }

    public Instituicao_Tags(string tagId,string codInstituicao)
    {
        Id = new Identifier(Guid.NewGuid());
        InstituicaoCodigo = new InstituicaoCodigo(codInstituicao);
        TagId = new Identifier(tagId);
    }

}