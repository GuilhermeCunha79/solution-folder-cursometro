namespace WebApplication1.Domain.Calculo;

public class CalculoDTO
{
    public Guid Id;
    public string MediaSecundario;
    public string MediaIngresso;
    public string MediaIngressoDesporto;

    public CalculoDTO(Guid id, string mediaSecundario, string mediaIngresso, string mediaIngressoDesporto)
    {
        Id = id;
        MediaSecundario = mediaSecundario;
        MediaIngresso = mediaIngresso;
        MediaIngressoDesporto = mediaIngressoDesporto;
    }
}