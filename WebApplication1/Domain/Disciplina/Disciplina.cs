using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina;

public class Disciplina:Entity<Identifier>
{
    public DisciplinaNome DisciplinaNome { get; set; }
    public DisciplinaTipo DisciplinaTipo { get; set; }
    
    public ICollection<WebApplication1.Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> Disciplina_CursoSecundario { get; set; }
    public ICollection<Teste.Teste> Testes { get; set; }
    
    public Disciplina()
    {
        
    }

    public Disciplina(string nomeDisciplina, string tipo)
    {
        DisciplinaNome = new DisciplinaNome(nomeDisciplina);
        DisciplinaTipo = new DisciplinaTipo(tipo);
    }
}