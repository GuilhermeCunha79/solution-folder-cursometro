using WebApplication1.Domain.Vagas;
using WebApplication1.Shared;

namespace WebApplication1.Domain.InformacoesCandidatura;

public class InformacoesCandidatura : Entity<Identifier>
{
    public NotaEntradaValor NotaEntradaValor { get; set; }
    public VagasNumero VagasNumero { get; set; }
    
    public Candidatura.Candidatura Candidatura { get; set; }

    public InformacoesCandidatura()
    {
        
    }

    public InformacoesCandidatura(int notaEntrada, int vagas)
    {
        Id = new Identifier(Guid.NewGuid());
        NotaEntradaValor = new NotaEntradaValor(notaEntrada);
        VagasNumero = new VagasNumero(vagas);
    }
}