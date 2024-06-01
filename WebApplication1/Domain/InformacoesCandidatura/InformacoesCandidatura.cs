using WebApplication1.Domain.Vagas;
using WebApplication1.Shared;

namespace WebApplication1.Domain.InformacoesCandidatura;

public class InformacoesCandidatura : Entity<Identifier>
{
    public NotaEntradaValor NotaEntradaValor { get; set; }
    public VagasNumero VagasNumero { get; set; }
    public Identifier IdCandidatura { get; set; }

    public Candidatura.Candidatura Candidatura { get; set; }

    public InformacoesCandidatura()
    {
        
    }

    public InformacoesCandidatura(int notaEntrada, int vagas, int idCandidatura)
    {
        NotaEntradaValor = new NotaEntradaValor(notaEntrada);
        VagasNumero = new VagasNumero(vagas);
        IdCandidatura = new Identifier(idCandidatura);
    }
}