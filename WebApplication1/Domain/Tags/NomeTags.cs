using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class NomeTags : IValueObject
{

    public string NomeTag { get; }

    public NomeTags()
    {
    }

    public NomeTags(string tag)
    {
        NomeTag = tag;
    }


}