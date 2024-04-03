using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class NomeTags : IValueObject
{

    private List<string> Tags { get; }

    public NomeTags()
    {
        Tags = new List<string>();
    }

    public NomeTags(string tag)
    {
        Tags = new List<string> { tag };
    }

    public NomeTags(string[] tags)
    {
        Tags = new List<string>(tags);
    }
}