using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifAnual1:IValueObject
{
    public int Anual1Cif { get; set; }

    public CifAnual1()
    {
        
    }

    public CifAnual1(int anual1Cif)
    {
        Anual1Cif = anual1Cif;
    }
}