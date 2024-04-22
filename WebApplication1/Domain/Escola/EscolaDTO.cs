namespace WebApplication1.Domain.Escola;

public class EscolaDTO
{
    public Guid Id;
    public Guid IdDistrito;
    public Guid IdRegiao;
    public string NomeEscola;

    public EscolaDTO(Guid id,Guid idDistrito,Guid idRegiao, string nome)
    {
        Id = id;
        IdRegiao = idRegiao;
        IdDistrito=idDistrito;
        NomeEscola = nome;
    }
}