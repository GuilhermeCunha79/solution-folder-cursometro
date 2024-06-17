using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao_Tags;

public class Instituicao_Tags:Entity<Identifier>
{
    public Identifier TagId { get; set; }
    public Identifier InstituicaoCodigo { get; set; }

    public Instituicao.Instituicao Instituicao { get; set; }

    public Tags.Tags Tags { get; set; }


    public Instituicao_Tags()
    {
        
    }

    public Instituicao_Tags(int tagId,string codInstituicao)
    {
        InstituicaoCodigo = new InstituicaoCodigo(codInstituicao).Codigo;
        TagId = new Identifier(tagId);
    }

}