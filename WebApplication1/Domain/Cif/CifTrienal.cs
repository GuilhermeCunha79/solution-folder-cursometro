using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Cif;

public class CifTrienal:IValueObject
{
    public int TrienalCif { get; set; }

    public CifTrienal()
    {
        
    }

    public CifTrienal(int trienalCif)
    {
        TrienalCif = trienalCif;
    }
        
}