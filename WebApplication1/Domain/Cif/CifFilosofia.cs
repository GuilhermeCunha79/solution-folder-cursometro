using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

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