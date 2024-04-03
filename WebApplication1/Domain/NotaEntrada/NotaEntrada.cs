using WebApplication1.Shared;

namespace WebApplication1.Domain.NotaEntrada;

public class NotaEntrada : Entity<Identifier>
{
    public NotaEntradaAnoMenosUm NotaEntradaAnoMenosUm;
    public NotaEntradaAnoMenosDois NotaEntradaAnoMenosDois;
    public NotaEntradaAnoMenosTres NotaEntradaAnoMenosTres;

    public NotaEntrada()
    {
    }

    public NotaEntrada(string anoUm, string anoDois, string anoTres)
    {
        Id = new Identifier(Guid.NewGuid());
        NotaEntradaAnoMenosUm = new NotaEntradaAnoMenosUm(anoUm);
        NotaEntradaAnoMenosDois = new NotaEntradaAnoMenosDois(anoDois);
        NotaEntradaAnoMenosTres = new NotaEntradaAnoMenosTres(anoTres);
    }
}