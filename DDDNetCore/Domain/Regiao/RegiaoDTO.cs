namespace WebApplication1.Domain.Regiao;

public class RegiaoDTO
{
    public Guid Id;
    public string Regiao;

    public RegiaoDTO(Guid id, string regiao)
    {
        Id = id;
        Regiao = regiao;
    }
}