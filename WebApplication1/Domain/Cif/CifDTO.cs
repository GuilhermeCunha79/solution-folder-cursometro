namespace WebApplication1.Domain.Cif;

public class CifDTO
{
    public int Id;
    public int CifPortugues;
    public int CifEduFisica;
    public int CifFilosofia;
    public int CifLinguaEstrangeira;
    public int CifTrienal;
    public int CifBienal1;
    public int CifBienal2;
    public int CifAnual1;
    public int CifAnual2;
    public int UtilizadorId;

    public CifDTO(int id,int cifPortugues,int cifEduFisica,int cifFilosofia,int cifLinguaEstrangeira,int cifTrienal,
        int cifBienal1,int cifBienal2, int cifAnual1,int cifAnual2,int utilizadorId)
    {
        Id = id;
        CifPortugues = cifPortugues;
        CifEduFisica = cifEduFisica;
        CifFilosofia = cifFilosofia;
        CifLinguaEstrangeira = cifLinguaEstrangeira;
        CifTrienal = cifTrienal;
        CifBienal1 = cifBienal1;
        CifBienal2 = cifBienal2;
        CifAnual1 = cifAnual1;
        CifAnual2 = cifAnual2;
        UtilizadorId = utilizadorId;
    }
}