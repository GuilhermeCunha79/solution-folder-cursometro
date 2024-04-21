namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngressoDTO
{
    public Guid Id;
    public Guid IdUtilizador;
    public string InstituicaoCursoCodigo;

    public Utilizador_ExameIngressoDTO(Guid id, Guid idUtilizador, string instituicaoCursoCodigo)
    {
        Id = id;
        IdUtilizador = idUtilizador;
        InstituicaoCursoCodigo = instituicaoCursoCodigo;
    }
}