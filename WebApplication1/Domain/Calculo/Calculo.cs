using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo;

public class Calculo : Entity<Identifier>
{
    public MediaIngresso MediaIngresso { get; set; }
    public MediaIngressoDesporto MediaIngressoDesporto { get; set; }
    public MediaSecundario MediaSecundario { get; set; }
    
    public ICollection<Calculo_ExameIngresso.Calculo_ExameIngresso> CalculoExameIngresso { get; set; }
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