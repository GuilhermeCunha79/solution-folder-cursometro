using System.ComponentModel.DataAnnotations;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoNotaExame:IValueObject
{

    public string NotaExameIngresso { get; set; }

    public Disciplina_CursoNotaExame()
    {
    }

    public Disciplina_CursoNotaExame(string nota)
    {
        NotaExameIngresso = nota;
    }
}