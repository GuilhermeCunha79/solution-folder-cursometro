using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoTipoEnsino : IValueObject
{
    private string TipoEnsino { get; set; }

    public InstituicaoTipoEnsino()
    {
        
    }

    public InstituicaoTipoEnsino(string tipoEnsino)
    {
        TipoEnsino = tipoEnsino;
    }
}