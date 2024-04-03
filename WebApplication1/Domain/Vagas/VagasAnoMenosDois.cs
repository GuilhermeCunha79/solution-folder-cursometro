using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class VagasAnoMenosDois:IValueObject
{
    private string? VagaMenosDois { get; set; }

    public VagasAnoMenosDois()
    {
        
    }
    
    public VagasAnoMenosDois(string? vagas)
    {
        VagaMenosDois = vagas;
    }
    
}