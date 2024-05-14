using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Teste;

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