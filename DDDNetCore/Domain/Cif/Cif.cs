using WebApplication1.Domain.Disciplina;
using WebApplication1.Domain.Disciplina_CursoSecundario;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public class Cif : Entity<Identifier>
{
    public Disciplina_CursoCifDisciplina DisciplinaCursoCifDisciplina { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Identifier DisciplinaCodigo { get; set; }
    public bool Active { get; set; }

    public Cif()
    {
    }

    public Cif(int cifDisciplina, int idUtilizador, string disciplinaCodigo)

    {
        DisciplinaCursoCifDisciplina = new Disciplina_CursoCifDisciplina(cifDisciplina);
        UtilizadorId = new Identifier(idUtilizador);
        DisciplinaCodigo = new DisciplinaCodigo(disciplinaCodigo).CodigoDisciplina;
        Active = true;
    }

    public void ChangeCifDisciplina(Disciplina_CursoCifDisciplina disciplinaCursoCifDisciplina)
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "Adicione uma nota de 'Classificação Interna Final' válida.");
        DisciplinaCursoCifDisciplina = disciplinaCursoCifDisciplina ??
                        throw new BusinessRuleValidationException(
                            "Adicione uma nota de 'Classificação Interna Final' válida.");
    }
}