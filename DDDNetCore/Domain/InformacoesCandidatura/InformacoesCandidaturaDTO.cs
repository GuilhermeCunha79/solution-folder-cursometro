namespace WebApplication1.Domain.InformacoesCandidatura;

public class InformacoesCandidaturaDTO
{
    public int Id;
    public int NotaEntrada;
    public int NrVagas;
    public int CandidaturaId;

    public InformacoesCandidaturaDTO(int id, int notaEntrada, int nrVagas, int candidaturaId)
    {
        Id = id;
        NotaEntrada = notaEntrada;
        NrVagas = nrVagas;
        CandidaturaId = candidaturaId;
    }
}