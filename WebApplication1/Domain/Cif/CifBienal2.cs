using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifBienal2:IValueObject
{
    public int Bienal2Cif { get; set; }

    public CifBienal2()
    {
        
    }

    public CifBienal2(int bienal2Cif)
    {
        Bienal2Cif = bienal2Cif;
    }
}