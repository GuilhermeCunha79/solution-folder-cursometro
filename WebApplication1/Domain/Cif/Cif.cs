using ConsoleApp1.Domain.Cif;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public class Cif : Entity<Identifier>
{
    public CifPortugues CifPortugues { get; set; }
    public CifEduFisica CifEduFisica { get; set; }
    public CifFilosofia CifFilosofia { get; set; }
    public CifLinguaEstrangeira CifLinguaEstrangeira { get; set; }
    public CifTrienal CifTrienal { get; set; }
    public CifBienal1 CifBienal1 { get; set; }
    public CifBienal2 CifBienal2 { get; set; }
    public CifAnual1 CifAnual1 { get; set; }
    public CifAnual2 CifAnual2 { get; set; }

    public Identifier UtilizadorId { get; set; }

    public Cif()
    {
        
    }

    public Cif(int cifPortugues, int cifEduFisica, int cifFilosofia, int cifLinguaEstr, int cifTrienal, int cifBienal1,
        int cifBienal2, int cifAnual1, int cifAnual2, int idUtilizador)

    {
        CifPortugues = new CifPortugues(cifPortugues);
        CifEduFisica = new CifEduFisica(cifEduFisica);
        CifFilosofia = new CifFilosofia(cifFilosofia);
        CifLinguaEstrangeira = new CifLinguaEstrangeira(cifLinguaEstr);
        CifTrienal = new CifTrienal(cifTrienal);
        CifBienal1 = new CifBienal1(cifBienal1);
        CifBienal2 = new CifBienal2(cifBienal2);
        CifAnual1 = new CifAnual1(cifAnual1);
        CifAnual2 = new CifAnual2(cifAnual2);
        UtilizadorId = new Identifier(idUtilizador);
    }
}