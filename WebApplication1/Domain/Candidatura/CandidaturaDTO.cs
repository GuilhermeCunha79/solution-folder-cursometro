using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaDTO
{
    public Guid Id;
    public Guid IdVagas;
    public Guid IdNotaEntrada;
    public string AnoEntrada;
    public string Fase;

    public CandidaturaDTO(Guid id, Guid idVagas, Guid idNotaEntrada,string ano, string fase)
    {
        Id = id;
        IdVagas = idVagas;
        IdNotaEntrada = idNotaEntrada;
        AnoEntrada = ano;
        Fase = fase;
    }
}