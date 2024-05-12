using WebApplication1.Shared;

namespace WebApplication1.Domain.Regiao;

public class RegiaoCodigo:IValueObject
{
    public Identifier CodigoIsoRegiao { get; set; }

    public RegiaoCodigo()
    {
        
    }

    public RegiaoCodigo(string isoCodigo)
    {
        CodigoIsoRegiao = new Identifier(isoCodigo);
    }
}