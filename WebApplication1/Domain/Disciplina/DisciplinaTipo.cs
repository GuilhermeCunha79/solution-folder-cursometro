using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Disciplina;

public class DisciplinaTipo:IValueObject
{
    public string TipoDisciplina { get; set; }

    public DisciplinaTipo()
    {
        
    }

    public DisciplinaTipo(string tipo)
    {
        TipoDisciplina = tipo;
    }
}