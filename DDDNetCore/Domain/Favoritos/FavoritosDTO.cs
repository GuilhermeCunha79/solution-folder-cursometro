namespace WebApplication1.Domain.Favoritos;

public class FavoritosDTO
{
    public int Id;
    public string IdUtilizador;
    public string InstituicaoCursoCodigo;

    public FavoritosDTO(int id,string idUtilizador, string instituicaoCursoCodigo)
    {
        Id = id;
        IdUtilizador = idUtilizador;
        InstituicaoCursoCodigo = instituicaoCursoCodigo;
    }

}