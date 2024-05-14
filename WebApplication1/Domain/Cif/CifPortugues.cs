using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

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