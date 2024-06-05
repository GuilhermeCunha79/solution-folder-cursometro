using WebApplication1.Shared;

namespace WebApplication1.Domain.Media;

public class MediaIngressoDesporto : IValueObject
{
    public string? IngressoMediaDesporto { get; set; }

    public MediaIngressoDesporto()
    {
        
    }

    public MediaIngressoDesporto(string? ingressoMediaDesporto)
    {
        IngressoMediaDesporto = ingressoMediaDesporto;
    }
}