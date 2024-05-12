using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Disciplina;

public class Disciplina:Entity<Identifier>
{
    public DisciplinaNome DisciplinaNome { get; set; }

    public Disciplina()
    {
        
    }

    public Disciplina(string codigoDisc,string nomeDisciplina)
    {
        Id = new DisciplinaCodigo(codigoDisc).CodigoDisciplina;
        DisciplinaNome = new DisciplinaNome(nomeDisciplina);
    }
}