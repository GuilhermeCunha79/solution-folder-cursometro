namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngressoDTO
{
    public Guid Id;
    public string CodigoExame;
    public string NomeExame;

    public ExameIngressoDTO(Guid id,string codigoExame, string nomeExame)
    {
        Id = id;
        CodigoExame = codigoExame;
        NomeExame = nomeExame;
    }
}