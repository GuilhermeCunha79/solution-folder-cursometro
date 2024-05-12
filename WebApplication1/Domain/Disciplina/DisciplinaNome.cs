using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Disciplina;

public class DisciplinaNome:IValueObject
{
    public string NomeDisciplina { get; set; }

    public DisciplinaNome()
    {
        
    }

    public DisciplinaNome(string nomeDisciplina)
    {
        NomeDisciplina = nomeDisciplina;
    }
}