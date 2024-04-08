namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntradaDTO
{
    public Guid Id;
    public string NotaEntradaMenosUm;
    public string NotaEntradaMenosDois;
    public string NotaEntradaMenosTres;

    public NotaEntradaDTO(Guid id, string notaEntradaMenosUm, string notaEntradaMenosDois, string notaEntradaMenosTres)
    {
        Id = id;
        NotaEntradaMenosUm = notaEntradaMenosUm;
        NotaEntradaMenosDois = notaEntradaMenosDois;
        NotaEntradaMenosTres = notaEntradaMenosTres;
    }
}