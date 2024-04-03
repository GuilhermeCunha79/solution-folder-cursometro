using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class Vagas : Entity<Identifier>
{
    public VagasAnoMenosUm VagasAnoMenosUm { get; set; }
    public VagasAnoMenosDois VagasAnoMenosDois { get; set; }
    public VagasMenosTres VagasMenosTres { get; set; }

    public Vagas()
    {
        
    }
    
    public Vagas(string anoUm, string anoDois, string anoTres)
    {
        Id = new Identifier(Guid.NewGuid());
        VagasAnoMenosUm = new VagasAnoMenosUm(anoUm);
        VagasAnoMenosDois = new VagasAnoMenosDois(anoDois);
        VagasMenosTres = new VagasMenosTres(anoTres);
    }
}