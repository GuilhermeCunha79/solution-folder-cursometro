namespace WebApplication1.Domain.InformacoesCandidatura;

public class InformacoesCandidaturaDTO
{
    public Guid Id;
    public int NotaEntrada;
    public int NrVagas;

    public InformacoesCandidaturaDTO(Guid id, int notaEntrada, int nrVagas)
    {
        Id = id;
        NotaEntrada = notaEntrada;
        NrVagas = nrVagas;
    }
}