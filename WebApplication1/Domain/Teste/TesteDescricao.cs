using WebApplication1.Shared;

namespace WebApplication1.Domain.Teste;

public class TesteDescricao:IValueObject
{
    public string DescricaoTeste { get; set; }

    public TesteDescricao()
    {
        
    }

    public TesteDescricao(string descricaoTeste)
    {
        DescricaoTeste = descricaoTeste;
    }
}