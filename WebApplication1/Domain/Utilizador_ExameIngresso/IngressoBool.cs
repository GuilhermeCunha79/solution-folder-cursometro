using WebApplication1.Shared;

namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class IngressoBool:IValueObject
{
    public bool BoolIngresso { get; set; }

    public IngressoBool()
    {
        
    }

    public IngressoBool(bool boolIngresso)
    {
        BoolIngresso = boolIngresso;
    }
}