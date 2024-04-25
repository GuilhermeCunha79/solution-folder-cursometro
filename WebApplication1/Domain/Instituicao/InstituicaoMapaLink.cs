using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoMapaLink : IValueObject
{
    public string MapaLink { get; set; }

    public InstituicaoMapaLink()
    {
    }

    public InstituicaoMapaLink(string mapaLink)
    {
        MapaLink = mapaLink;
    }
}