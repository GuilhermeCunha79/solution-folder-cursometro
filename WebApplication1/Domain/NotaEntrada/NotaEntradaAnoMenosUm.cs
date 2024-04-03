using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntradaAnoMenosUm : IValueObject
{
    private string? AnoMenosUm { get; set; }

    public NotaEntradaAnoMenosUm()
    {
        
    }
    
    public NotaEntradaAnoMenosUm(string? anoUm)
    {
        AnoMenosUm = anoUm;
    }
}