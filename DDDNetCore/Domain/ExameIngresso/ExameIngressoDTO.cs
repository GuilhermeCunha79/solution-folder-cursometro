namespace WebApplication1.Domain.ExameIngresso;

public class ExameIngressoDTO
{
    public string CodigoExame;
    public string NomeExame;

    public ExameIngressoDTO(string codigoExame, string nomeExame)
    {
        CodigoExame = codigoExame;
        NomeExame = nomeExame;
    }
}