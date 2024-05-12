using ConsoleApp1.Domain.CursoSecundario;
using ConsoleApp1.Domain.Disciplina;
using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundario : Entity<Identifier>
{
    public Identifier DisciplinaCodigo { get; set; }
    public Identifier CodigoCursoSecundario { get; set; }

    public Disciplina_CursoSecundario()
    {
    }

    public Disciplina_CursoSecundario(string codigoDisciplina, string codigoCursoSecundario)
    {
        DisciplinaCodigo = new DisciplinaCodigo(codigoDisciplina).CodigoDisciplina;
        CodigoCursoSecundario = new CursoSecundarioCodigo(codigoCursoSecundario).CodigoCursoSecundario;
    }
}