using WebApplication1.Shared;

namespace WebApplication1.Domain.Vagas;

public class VagasMenosTres: IValueObject
{

    private string? VagaMenosTres { get; set; }

    public VagasMenosTres()
    {
        
    }

    public VagasMenosTres(string? vagas)
    {
        VagaMenosTres = vagas;
    }
}