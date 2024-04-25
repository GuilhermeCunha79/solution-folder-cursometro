using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo;

public class Medias : Entity<Identifier>
{
    public MediaIngresso MediaIngresso { get; set; }
    public MediaIngressoDesporto MediaIngressoDesporto { get; set; }
    public MediaSecundario MediaSecundario { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public Identifier IdUtilizador { get; set; }
    
    public Medias()
    {
        
    }

    public Medias(string mediaSecundario, string? mediaIngresso, string? mediaIngressoDesporto)
    {
        Id = new Identifier(Guid.NewGuid());
        MediaSecundario = new MediaSecundario(mediaSecundario);
        MediaIngresso = new MediaIngresso(mediaIngresso);
        MediaIngressoDesporto = new MediaIngressoDesporto(mediaIngressoDesporto);
    }
}