namespace WebApplication1.Domain.Distrito;

public class DistritoDTO
{
    public Guid Id;
    public string Distrito;

    public DistritoDTO(Guid id, string distrito)
    {
        Id = id;
        Distrito = distrito;
    }
}