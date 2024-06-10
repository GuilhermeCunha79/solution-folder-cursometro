using WebApplication1.Shared;

namespace WebApplication1.Domain.Escola;

public class EscolaCodigo:IValueObject
{
    public Identifier CodigoEscola { get; set; }

    public EscolaCodigo()
    {
        
    }

    public EscolaCodigo(int codigo)
    {
        CodigoEscola = new Identifier(codigo);
    }

}