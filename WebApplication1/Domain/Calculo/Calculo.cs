using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo;

public class Calculo : Entity<Identifier>
{
    public MediaIngresso MediaIngresso;
    public MediaIngressoDesporto MediaIngressoDesporto;
    public MediaSecundario MediaSecundario;

    public Calculo()
    {
        
    }

    public Calculo(string mediaSecundario, string? mediaIngresso, string? mediaIngressoDesporto)
    {
        Id = new Identifier(Guid.NewGuid());
        MediaSecundario = new MediaSecundario(mediaSecundario);
        MediaIngresso = new MediaIngresso(mediaIngresso);
        MediaIngressoDesporto = new MediaIngressoDesporto(mediaIngressoDesporto);
    }
}