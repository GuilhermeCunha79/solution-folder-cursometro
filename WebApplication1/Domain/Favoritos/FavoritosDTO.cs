namespace WebApplication1.Domain.Favoritos;

public class FavoritosDTO
{

    public Guid Id;
    public Guid IdUtilizador;
    public string InstituicaoCursoCodigo;

    public FavoritosDTO(Guid id, Guid idUtilizador, string instituicaoCursoCodigo)
    {
        Id = id;
        IdUtilizador = idUtilizador;
        InstituicaoCursoCodigo = instituicaoCursoCodigo;
    }

}