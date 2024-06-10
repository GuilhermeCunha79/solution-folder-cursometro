namespace WebApplication1.Domain.Disciplina;

public class DisciplinaDTO
{
    public int Idd;
    public string DisciplinaNome;
    public string DisciplinaTipo;

    public DisciplinaDTO(int id,string disciplinaNome, string disciplinaTipo)
    {
        Idd = id;
        DisciplinaNome = disciplinaNome;
        DisciplinaTipo = disciplinaTipo;
    }
}