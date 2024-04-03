using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntradaAnoMenosTres: IValueObject
{
    private string AnoMenosTres { get; set; }

    public NotaEntradaAnoMenosTres()
    {
        
    }
    
    public NotaEntradaAnoMenosTres(string anoMenosTres)
    {
        AnoMenosTres = anoMenosTres;
    }
}