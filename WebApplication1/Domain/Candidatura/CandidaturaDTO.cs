namespace WebApplication1.Domain.Candidatura;

public class CandidaturaDTO
{
    public Guid Id;
    public Guid IdVagas;
    public Guid IdNotaEntrada;

    public CandidaturaDTO(Guid id, Guid idVagas, Guid idNotaEntrada)
    {
        Id = id;
        IdVagas = idVagas;
        IdNotaEntrada = idNotaEntrada;
    }
}