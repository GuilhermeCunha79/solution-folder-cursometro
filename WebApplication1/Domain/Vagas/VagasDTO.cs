namespace WebApplication1.Domain.Vagas;

public class VagasDTO
{
    public Guid Id;
    public string VagasNumero;

    public VagasDTO(Guid id, string vagasNumero)
    {
        Id = id;
        VagasNumero = vagasNumero;
    }
}