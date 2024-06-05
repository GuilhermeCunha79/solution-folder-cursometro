namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundarioDTO
{
    public int CodigoCursoSecundario;
    public string NomeCursoSecundario;

    public CursoSecundarioDTO(int codigoCursoSecundario, string nomeCursoSecundario)
    {
        CodigoCursoSecundario = codigoCursoSecundario;
        NomeCursoSecundario = nomeCursoSecundario;
    }
}