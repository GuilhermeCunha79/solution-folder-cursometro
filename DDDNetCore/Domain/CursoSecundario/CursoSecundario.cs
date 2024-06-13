using WebApplication1.Shared;

namespace WebApplication1.Domain.CursoSecundario;

public class CursoSecundario : Entity<Identifier>
{
    public Identifier CursoSecundarioCodigo { get; set; }
    public CursoSecundarioNome CursoSecundarioNome { get; set; }
    public ICollection<WebApplication1.Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> Disciplina_CursoSecundario { get; set; }
    public bool Active { get; set; }
    
    public CursoSecundario()
    {
        
    }

    public CursoSecundario(int codigo, string nomeCurso)
    {
        CursoSecundarioCodigo = new CursoSecundarioCodigo(codigo).CodigoCursoSecundario;
        CursoSecundarioNome = new CursoSecundarioNome(nomeCurso);
        Active = true;
    }
    
    public void ChangeCursoSecundarioNome(CursoSecundarioNome fase)
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "O Curso Secundário não se encontra ativo.");
        CursoSecundarioNome = fase ??
                              throw new BusinessRuleValidationException(
                                  "Adicione um 'Nome de Curso' válidao.");
    }

    public void ChangeCursoSecundarioCodigo(CursoSecundarioCodigo fase)
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "O Curso Secundário não se encontra ativo.");
        CursoSecundarioCodigo = fase.CodigoCursoSecundario ??
                                throw new BusinessRuleValidationException(
                                    "Adicione um 'Código de Curso' válido.");
    }
    
    public void MarkAsInactive()
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "A Candidatura selecionada já se encontra inativa.");
        Active = false;
    }
}
