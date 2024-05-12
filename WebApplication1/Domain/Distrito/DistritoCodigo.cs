using WebApplication1.Shared;

namespace WebApplication1.Domain.Distrito;

public class DistritoCodigo:IValueObject
{
    public Identifier CodigoDistrito { get; set; }

    public DistritoCodigo()
    {
        
    }

    public DistritoCodigo(string codigoDistrito)
    {
        CodigoDistrito = new Identifier(codigoDistrito);
    }
}