using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoCodigo:IValueObject
{
    public Identifier Codigo { get; set; }

    public Disciplina_CursoCodigo()
    {
        
    }
    
    public Disciplina_CursoCodigo(string idDisciplina, int utilizadorId)
    {
        Codigo = new Identifier(idDisciplina + "/" + utilizadorId);
    }
}