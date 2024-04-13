using WebApplication1.Shared;

namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngressoCodigo:IValueObject
{
    public string CodigoExameIngresso { get; set; }

    public ExameIngressoCodigo()
    {
        
    }

    public ExameIngressoCodigo(string codigoExameIngresso)
    {
        CodigoExameIngresso = codigoExameIngresso;
    }
    
}