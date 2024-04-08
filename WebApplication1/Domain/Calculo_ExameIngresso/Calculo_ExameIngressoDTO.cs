namespace WebApplication1.Domain.Calculo_ExameIngresso;

public class Calculo_ExameIngressoDTO
{
    public Guid Id;
    public string CodigoExame;
    public Guid IdCalculo;

    public Calculo_ExameIngressoDTO(Guid id, Guid idCalculo, string codigoExame)
    {
        Id = id;
        IdCalculo = idCalculo;
        CodigoExame = codigoExame;
    }
}