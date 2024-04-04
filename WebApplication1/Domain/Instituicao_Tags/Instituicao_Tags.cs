using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Tags;

public class Instituicao_Tags:Entity<Identifier>
{

    public InstituicaoCodigo InstituicaoCodigo;
    public Identifier TagsIdentifier;

    public Instituicao_Tags()
    {
        
    }

    public Instituicao_Tags(string codInstituicao, string tagId)
    {
        Id = new Identifier(Guid.NewGuid());
        InstituicaoCodigo = new InstituicaoCodigo(codInstituicao);
        TagsIdentifier = new Identifier(tagId);
    }

}