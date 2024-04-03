using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntradaAnoMenosDois:IValueObject
{
    private string AnoMenosDois { get; set; }

    public NotaEntradaAnoMenosDois()
    {
        
    }

    public NotaEntradaAnoMenosDois(string anoMenosDois)
    {
        AnoMenosDois = anoMenosDois;
    }
}