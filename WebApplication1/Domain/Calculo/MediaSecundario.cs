using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo;

public class MediaSecundario : IValueObject
{

    public string? SecundarioMedia { get; set; }

    public MediaSecundario()
    {
        
    }

    public MediaSecundario(string? secundarioMedia)
    {
        SecundarioMedia = secundarioMedia;
    }
}