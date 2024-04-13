using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo;

public class MediaIngresso : IValueObject
{

    public string? IngressoMedia { get; set; }

    public MediaIngresso()
    {
        
    }

    public MediaIngresso(string? ingressoMedia)
    {
        IngressoMedia = ingressoMedia;
    }

}