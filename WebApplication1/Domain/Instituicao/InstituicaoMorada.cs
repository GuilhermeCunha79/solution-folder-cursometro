using WebApplication1.Shared;

namespace WebApplication1.Domain.Instituicao;

public class InstituicaoMorada : IValueObject
{

    public string Morada { get; set; }

    public InstituicaoMorada()
    {
        
    }
    
    public InstituicaoMorada(string morada)
    {
        Morada = morada;
    }
}