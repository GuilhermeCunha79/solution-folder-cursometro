using WebApplication1.Domain.Disciplina;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Cif;

public class Cif : Entity<Identifier>
{
    public CifDisciplina CifDisciplina { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Identifier DisciplinaCodigo { get; set; }
    public bool Active { get; set; }

    public Cif()
    {
    }

    public Cif(int cifDisciplina, int idUtilizador, string disciplinaCodigo)

    {
        CifDisciplina = new CifDisciplina(cifDisciplina);
        UtilizadorId = new Identifier(idUtilizador);
        DisciplinaCodigo = new DisciplinaCodigo(disciplinaCodigo).CodigoDisciplina;
        Active = true;
    }

    public void ChangeCifDisciplina(CifDisciplina cifDisciplina)
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "Adicione uma nota de 'Classificação Interna Final' válida.");
        CifDisciplina = cifDisciplina ??
                        throw new BusinessRuleValidationException(
                            "Adicione uma nota de 'Classificação Interna Final' válida.");
    }
}