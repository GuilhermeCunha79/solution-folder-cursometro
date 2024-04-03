using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class VagasAnoMenosUm: IValueObject
{
    private string? VagaMenosUm { get; set; }

    public VagasAnoMenosUm()
    {
        
    }

    public VagasAnoMenosUm(string? vagas)
    {
        VagaMenosUm = vagas;
    }
}