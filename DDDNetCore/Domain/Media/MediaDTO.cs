namespace WebApplication1.Domain.Media;

public class MediaDTO
{
    public int Id;
    public string MediaSecundario;
    public string? MediaIngresso;
    public string? MediaIngressoDesporto;
    public string UtilizadorId;

    public MediaDTO(int id, string mediaSecundario, string? mediaIngresso, string? mediaIngressoDesporto, string idUtilizador)
    {
        Id = id;
        MediaSecundario = mediaSecundario;
        MediaIngresso = mediaIngresso;
        MediaIngressoDesporto = mediaIngressoDesporto;
        UtilizadorId = idUtilizador;
    }
}