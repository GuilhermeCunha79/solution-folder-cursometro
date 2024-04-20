using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaDTO
{
    public Guid Id;
    public Guid IdVagas;
    public Guid IdNotaEntrada;
    public int AnoEntrada;
    public int Fase;

    public CandidaturaDTO(Guid id, Guid idVagas, Guid idNotaEntrada,int ano, int fase)
    {
        Id = id;
        IdVagas = idVagas;
        IdNotaEntrada = idNotaEntrada;
        AnoEntrada = ano;
        Fase = fase;
    }
}