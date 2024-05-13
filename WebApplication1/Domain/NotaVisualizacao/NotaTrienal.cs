using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Nota;

public class NotaTrienal:IValueObject
{
    public Identifier IdDisciplinaTrienal { get; set; }
    public int NotaTrienalDecimo { get; set; }
    public int NotaTrienalDecimoPrim { get; set; }
    public int NotaTrienalDecimoSeg { get; set; }

    public NotaTrienal()
    {
        
    }

    public NotaTrienal(int idDisciplinaTrienal, int notaTrienalDecimo, int notaTrienalDecimoPrim, int notaTrienalDecimoSeg)
    {
        IdDisciplinaTrienal = new Identifier(idDisciplinaTrienal);
        NotaTrienalDecimo = notaTrienalDecimo;
        NotaTrienalDecimoPrim = notaTrienalDecimoPrim;
        NotaTrienalDecimoSeg = notaTrienalDecimoSeg;
    }

}