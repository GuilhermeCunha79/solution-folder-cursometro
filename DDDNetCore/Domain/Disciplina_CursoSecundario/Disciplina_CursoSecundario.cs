using WebApplication1.Domain.Cif;
using WebApplication1.Domain.CursoSecundario;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundario : Entity<Identifier>
{
    public Identifier DisciplinaCodigo { get; set; }
    public Identifier CodigoCursoSecundario { get; set; }
    public Disciplina_CursoSecundarioNota DisciplinaCursoSecundarioNota { get; set; }
    public Disciplina_CursoCifDisciplina DisciplinaCursoCifDisciplina { get; set; }
    public Disciplina_CursoIngressoBool DisciplinaCursoIngressoBool { get; set; }
    public Disciplina_CursoNotaExame DisciplinaCursoNotaExame { get; set; }
    public Disciplina_CursoCodigo DisciplinaCursoCodigo { get; set; }
    public CursoSecundario.CursoSecundario CursoSecundario { get; set; }
    public Disciplina.Disciplina Disciplina { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public bool Active { get; set; }
    
    public ICollection<Teste.Teste> Testes { get; set; }

    public Disciplina_CursoSecundario()
    {
    }

    public Disciplina_CursoSecundario(string codigoDisciplina, int codigoCursoSecundario, string disciplinaDecimo,
        string disciplinaDecimoPrim, string disciplinaDecimoSeg, int cifDisciplina, string notaExame, bool isIngresso,
        int utilizadorId)
    {
        Id = new Disciplina_CursoCodigo(codigoDisciplina, utilizadorId).Codigo;
        DisciplinaCodigo = new DisciplinaCodigo(codigoDisciplina).CodigoDisciplina;
        CodigoCursoSecundario = new CursoSecundarioCodigo(codigoCursoSecundario).CodigoCursoSecundario;
        DisciplinaCursoSecundarioNota =
            new Disciplina_CursoSecundarioNota(disciplinaDecimo, disciplinaDecimoPrim, disciplinaDecimoSeg);
        DisciplinaCursoCifDisciplina = new Disciplina_CursoCifDisciplina(cifDisciplina);
        UtilizadorId = new Identifier(utilizadorId);
        DisciplinaCursoIngressoBool = new Disciplina_CursoIngressoBool(isIngresso);
        DisciplinaCursoNotaExame = new Disciplina_CursoNotaExame(notaExame);
        Active = true;
    }

    public void ChangeDisciplinaCursoNota(Disciplina_CursoSecundarioNota nota)
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "O Curso Secundário não se encontra ativo.");
        DisciplinaCursoSecundarioNota = nota ??
                                        throw new BusinessRuleValidationException(
                                            "Adicione um 'Código de Curso' válido.");
    }

    public void MarkAsInactive()
    {
        if (!Active)
            throw new BusinessRuleValidationException(
                "A Disciplina/Curso selecionada já se encontra inativa.");
        Active = false;
    }
}