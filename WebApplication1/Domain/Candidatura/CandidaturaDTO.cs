using WebApplication1.Shared;

namespace WebApplication1.Domain.Candidatura;

public class CandidaturaDTO
{
    public int Id;
    public string InstituicaoCursoCodigo;
    public int Ano;
    public int Fase;

    public CandidaturaDTO(int id, string instituicaoCursoCodigo,int ano, int fase)
    {
        Id = id;
        InstituicaoCursoCodigo = instituicaoCursoCodigo;
        Ano = ano;
        Fase = fase;
    }
}