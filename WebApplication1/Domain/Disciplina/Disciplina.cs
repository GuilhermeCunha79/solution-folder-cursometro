using WebApplication1.Shared;

namespace ConsoleApp1.Domain.Disciplina;

public class Disciplina:Entity<Identifier>
{
    public DisciplinaNome DisciplinaNome { get; set; }
    public DisciplinaTipo DisciplinaTipo { get; set; }
    
    public ICollection<Disciplina_CursoSecundario.Disciplina_CursoSecundario> Disciplina_CursoSecundario { get; set; }
    public ICollection<Teste.Teste> Testes { get; set; }
    
    public Disciplina()
    {
        
    }

    public Disciplina(string codigoDisc,string nomeDisciplina, string tipo)
    {
        Id = new DisciplinaCodigo(codigoDisc).CodigoDisciplina;
        DisciplinaNome = new DisciplinaNome(nomeDisciplina);
        DisciplinaTipo = new DisciplinaTipo(tipo);
    }
}