namespace WebApplication1.Domain.Vagas;

public class VagasDTO
{
    public Guid Id;
    public string VagasMenosUm;
    public string VagasMenosDois;
    public string VagasMenosTres;

    public VagasDTO(Guid id, string vagasMenosUm, string vagasMenosDois, string vagasMenosTres)
    {
        Id = id;
        VagasMenosUm = vagasMenosUm;
        VagasMenosDois = vagasMenosDois;
        VagasMenosTres = vagasMenosTres;
    }
}