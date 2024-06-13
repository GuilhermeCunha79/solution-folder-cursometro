namespace WebApplication1.Domain.Disciplina;

public class DisciplinaDTO
{
    public string Idd;
    public string DisciplinaNome;
    public string DisciplinaTipo;

    public DisciplinaDTO(string id,string disciplinaNome, string disciplinaTipo)
    {
        Idd = id;
        DisciplinaNome = disciplinaNome;
        DisciplinaTipo = disciplinaTipo;
    }
}