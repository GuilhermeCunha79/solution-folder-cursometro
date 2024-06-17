using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoCodigo: IValueObject
{
    public Identifier Codigo { get; set; }

    public InstituicaoCodigo()
    {
        
    }
    
    public InstituicaoCodigo(string codigo)
    {
        Codigo = new Identifier(codigo);
    }
}