namespace ConsoleApp1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioDTO
{
    public string DisciplinaCodigo;
    public string CodigoCursoSecundario;

    public Disciplina_CursoSecundarioDTO(string codigoDisciplina, string codigoCursoSecundario)
    {
        DisciplinaCodigo = codigoDisciplina;
        CodigoCursoSecundario = codigoCursoSecundario;
    }
}