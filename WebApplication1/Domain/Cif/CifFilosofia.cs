using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifFilosofia:IValueObject
{
    public int FilosofiaCif { get; set; }

    public CifFilosofia()
    {
        
    }

    public CifFilosofia(int filosofiaCif)
    {
        FilosofiaCif = filosofiaCif;
    }
}