using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class TagDescricao:IValueObject
{
    public string Descricao { get; set; }

    public TagDescricao()
    {
        
    }
    
    public TagDescricao(string descricao)
    {
        Descricao = descricao;
    }
}