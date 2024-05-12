using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngressoCodigo:IValueObject
{
    public Identifier CodigoExameIngresso { get; set; }

    public ExameIngressoCodigo()
    {
        
    }

    public ExameIngressoCodigo(string codigoExameIngresso)
    {
        CodigoExameIngresso = new Identifier(codigoExameIngresso);
    }
    
    public Identifier GetCodigoExameIngresso()
    {
        return CodigoExameIngresso;
    }
    
}