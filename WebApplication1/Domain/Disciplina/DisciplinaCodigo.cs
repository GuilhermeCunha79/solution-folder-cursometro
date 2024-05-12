using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Disciplina;

public class DisciplinaCodigo:IValueObject
{
    public Identifier CodigoDisciplina { get; set; }

    public DisciplinaCodigo()
    {
        
    }

    public DisciplinaCodigo(string codigoDisciplina)
    {
        CodigoDisciplina = new Identifier(codigoDisciplina);
    }
}