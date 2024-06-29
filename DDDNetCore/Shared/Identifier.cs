using Newtonsoft.Json;

namespace WebApplication1.Shared;

public class Identifier : EntityId
{
    
    
    [JsonConstructor]
    
    public Identifier(int value) : base(value)
    {
    }
    public Identifier(Guid value) : base(value)
    {
    }
    public Identifier(String value) : base(value)
    {
    }

    override
        public String AsString()
    {
        Guid obj = (Guid)Value;
        return obj.ToString();
    }
}