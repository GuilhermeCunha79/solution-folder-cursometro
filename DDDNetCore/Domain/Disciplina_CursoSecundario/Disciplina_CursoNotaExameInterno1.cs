using System.ComponentModel.DataAnnotations;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoNotaExameInterno1:IValueObject
{

    public string? NotaExameInterno1 { get; set; }

    public Disciplina_CursoNotaExameInterno1()
    {
    }

    public Disciplina_CursoNotaExameInterno1(string nota)
    {
        NotaExameInterno1 = nota;
    }
}