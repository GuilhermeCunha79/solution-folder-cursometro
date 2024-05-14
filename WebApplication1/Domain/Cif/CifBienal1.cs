using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifBienal1:IValueObject
{
    public int Bienal1Cif { get; set; }

    public CifBienal1()
    {
        
    }

    public CifBienal1(int bienal1Cif)
    {
        Bienal1Cif = bienal1Cif;
    }
}