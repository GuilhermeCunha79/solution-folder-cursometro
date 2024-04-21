namespace WebApplication1.Domain.Insituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngressoDTO
{
    public Guid Id;
    public Guid IdUtilizador;
    public int NotaExame;

    public Instituicao_Curso_ExameIngressoDTO(Guid id, Guid idUtilizador, int notaExame)
    {
        Id = id;
        IdUtilizador = idUtilizador;
        NotaExame = notaExame;
    }
}