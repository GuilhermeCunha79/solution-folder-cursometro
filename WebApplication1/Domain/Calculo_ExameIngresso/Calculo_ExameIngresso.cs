using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Calculo_ExameIngresso;

public class Calculo_ExameIngresso : Entity<Identifier>
{
    public ExameIngressoCodigo ExameIngressoCodigo { get; set; }
    public Identifier IdCalculo { get; set; }
    public ExameIngresso.ExameIngresso ExameIngresso { get; set; }
    public Calculo.Calculo Calculo { get; set; }

    public Calculo_ExameIngresso()
    {
    }

    public Calculo_ExameIngresso(string idCalculo, string exameCodigo)
    {
        Id = new Identifier(Guid.NewGuid());
        ExameIngressoCodigo = new ExameIngressoCodigo(exameCodigo);
        IdCalculo = new Identifier(idCalculo);
    }
}