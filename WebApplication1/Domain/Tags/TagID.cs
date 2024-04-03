using WebApplication1.Shared;

namespace WebApplication1.Domain.Tags;

public class TagID:IValueObject
{
    private string IdTag { get; set; }

    public TagID()
    {
        
    }

    public TagID(string id)
    {
        IdTag = id;
    }
}