using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoCodigo: IValueObject
{
    private string Codigo { get; set; }

    public InstituicaoCodigo()
    {
        
    }
    
    public InstituicaoCodigo(string codigo)
    {
        Codigo = codigo;
    }
}