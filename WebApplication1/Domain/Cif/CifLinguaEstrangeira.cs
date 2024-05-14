using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifLinguaEstrangeira:IValueObject
{
    public int LinguaEstrangeiraCif { get; set; }

    public CifLinguaEstrangeira()
    {
        
    }

    public CifLinguaEstrangeira(int linguaEstrangeiraCif)
    {
        LinguaEstrangeiraCif = linguaEstrangeiraCif;
    }
}