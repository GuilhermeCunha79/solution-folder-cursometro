using System.ComponentModel.DataAnnotations;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;


public class Disciplina_CursoCif : IValueObject
{
    private int MAX_NOTA = 200;
    private int MIN_NOTA = 0;
    
    
    public int DisciplinaCif { get; set; }

    public Disciplina_CursoCif()
    {
    }

    public Disciplina_CursoCif(int disciplinaCif)
    {
        DisciplinaCif = CheckCifDisciplina(disciplinaCif);
    }

    public int CheckCifDisciplina(int cif)
    {

        if (MIN_NOTA > cif && cif > MAX_NOTA)
        {
            throw new BusinessRuleValidationException(
                "A 'Classificação Interna Final' deve ser um número interiro entre 0 e 200.");
        }

        return cif;
    }
}