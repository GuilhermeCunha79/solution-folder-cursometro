namespace ConsoleApp1.Domain.CursoSecundario;

public class CursoSecundarioDTO
{
    public string CodigoCursoSecundario;
    public string NomeCursoSecundario;

    public CursoSecundarioDTO(string codigoCursoSecundario, string nomeCursoSecundario)
    {
        CodigoCursoSecundario = codigoCursoSecundario;
        NomeCursoSecundario = nomeCursoSecundario;
    }
}