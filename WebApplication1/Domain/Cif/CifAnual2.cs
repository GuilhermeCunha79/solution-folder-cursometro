using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifAnual2:IValueObject
{
    public int Anual2Cif { get; set; }

    public CifAnual2()
    {
        
    }

    public CifAnual2(int anual2Cif)
    {
        Anual2Cif = anual2Cif;
    }
}