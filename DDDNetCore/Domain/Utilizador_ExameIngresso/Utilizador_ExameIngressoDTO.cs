namespace WebApplication1.Domain.Utilizador_ExameIngresso;

public class Utilizador_ExameIngressoDTO
{
    public Guid Id;
    public Guid IdUtilizador;
    public string InstituicaoCursoCodigo;
    public int NotaIngresso;

    public Utilizador_ExameIngressoDTO(Guid id, Guid idUtilizador, string instituicaoCursoCodigo, int notaExame)
    {
        Id = id;
        IdUtilizador = idUtilizador;
        InstituicaoCursoCodigo = instituicaoCursoCodigo;
        NotaIngresso = notaExame;
    }
}