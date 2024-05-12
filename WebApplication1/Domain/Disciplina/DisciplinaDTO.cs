namespace ConsoleApp1.Domain.Disciplina;

public class DisciplinaDTO
{
    public string DisciplinaCodigo;
    public string DisciplinaNome;

    public DisciplinaDTO(string disciplinaCodigo, string disciplinaNome)
    {
        DisciplinaCodigo = disciplinaCodigo;
        DisciplinaNome = disciplinaNome;
    }
}