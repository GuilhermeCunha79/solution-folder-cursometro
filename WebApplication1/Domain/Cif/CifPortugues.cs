using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public class CifPortugues:IValueObject
{
    public int PortuguesCif { get; set; }

    public CifPortugues()
    {
        
    }
        
    public CifPortugues(int portuguesCif)
    {
        PortuguesCif = portuguesCif;
    }
}