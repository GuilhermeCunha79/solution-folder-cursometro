namespace WebApplication1.Domain.Escola;

public class EscolaDTO
{
    public int Id;
    public string IdDistrito;
    public string NomeEscola;

    public EscolaDTO(int id,string idDistrito, string nome)
    {
        Id = id;
        IdDistrito=idDistrito;
        NomeEscola = nome;
    }
}