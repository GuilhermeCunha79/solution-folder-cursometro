using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaVisualizacao;

public class NotaVisualizacao : Entity<Identifier>
{
    public NotaPortugues NotaPortugues { get; set; }
    public NotaEduFisica NotaEduFisica { get; set; }
    public NotaFilosofia NotaFilosofia { get; set; }
    public NotaTrienal NotaTrienal { get; set; }
    public NotaBienal1 NotaBienal1 { get; set; }
    public NotaBienal2 NotaBienal2 { get; set; }
    public NotaAnual1 NotaAnual1 { get; set; }
    public NotaAnual2 NotaAnual2 { get; set; }
    
    public Utilizador.Utilizador Utilizador { get; set; }
    public Identifier UtilizadorId { get; set; }

    public NotaVisualizacao()
    {
    }

    public NotaVisualizacao(int notaPortuguesDecimo, int notaPortuguesDecimoPrim, int notaPortuguesDecimoSeg, int notaEduFisicaDecimo,
        int notaEduFisicaDecimoPrim, int notaEduFisicaDecimoSeg, int notaFilosofiaDecimo, int notaFilosofiaDecimoPrim,
        int idNotaTrienal, int notaTrienalDecimo, int notaTrienalDecimoPrim, int notaTrienalDecimoSeg, int idNotaBienal1,
        int notaBienal1Decimo, int notaBienal1DecimoPrim, int idNotaBienal2, int notaBienal2Decimo, int notaBienal2DecimoPrim,
        int idNotaAnual1, int notaAnual1DecimoSeg, int idNotaAnual2, int notaAnual2DecimoSeg)
    {
        NotaPortugues = new NotaPortugues(notaPortuguesDecimo,notaPortuguesDecimoPrim,notaPortuguesDecimoSeg);
        NotaEduFisica = new NotaEduFisica(notaEduFisicaDecimo,notaEduFisicaDecimoPrim,notaEduFisicaDecimoSeg);
        NotaFilosofia = new NotaFilosofia(notaFilosofiaDecimo,notaFilosofiaDecimoPrim);
        NotaTrienal = new NotaTrienal(idNotaTrienal, notaTrienalDecimo, notaTrienalDecimoPrim, notaTrienalDecimoSeg);
        NotaBienal1 = new NotaBienal1(idNotaBienal1,notaBienal1Decimo,notaBienal1DecimoPrim);
        NotaBienal2 = new NotaBienal2(idNotaBienal2,notaBienal2Decimo,notaBienal2DecimoPrim);
        NotaAnual1 = new NotaAnual1(idNotaAnual1,notaAnual1DecimoSeg);
        NotaAnual2 = new NotaAnual2(idNotaAnual2,notaAnual2DecimoSeg);
    }
}