using WebApplication1.Domain.CursoSecundario;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundario : Entity<Identifier>
{
    public Identifier DisciplinaId { get; set; }
    public Identifier CodigoExame { get; set; }
    public Disciplina_CursoSecundarioNota DisciplinaCursoSecundarioNota { get; set; }
    public Disciplina_CursoCif DisciplinaCursoCifDiscDisciplina { get; set; }
    public Disciplina_CursoIngresso DisciplinaCursoIngresso { get; set; }
    public Disciplina_CursoNotaExameInterno1 DisciplinaCursoNotaExameInterno1 { get; set; }
    public Disciplina_CursoNotaExameInterno2 DisciplinaCursoNotaExameInterno2 { get; set; }
    public Disciplina_CursoNotaExameExterno1 DisciplinaCursoNotaExameExterno1 { get; set; }
    public Disciplina_CursoNotaExameExterno2 DisciplinaCursoNotaExameExterno2 { get; set; }

    public Identifier CodigoCursoSecundario { get; set; }
    public CursoSecundario.CursoSecundario CursoSecundario { get; set; }
    public Disciplina.Disciplina Disciplina { get; set; }
    public Identifier UtilizadorId { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public bool Active { get; set; }

    public ICollection<Teste.Teste> Testes { get; set; }

    public Disciplina_CursoSecundario()
    {
    }

    public Disciplina_CursoSecundario(string codigoDisciplina, string codigoCursoSecundario, string disciplinaDecimo,
        string disciplinaDecimoPrim, string disciplinaDecimoSeg, int cifDisciplina, string notaExameInterno1,
        string notaExameInterno2, string notaExameExterno1, string notaExameExterno2, bool isIngresso,
        string utilizadorId, string codigoExame)
    {
        Id = new Disciplina_CursoCodigo(codigoDisciplina, utilizadorId).Codigo;
        DisciplinaId = new DisciplinaCodigo(codigoDisciplina).CodigoDisciplina;
        CodigoCursoSecundario = new CursoSecundarioCodigo(codigoCursoSecundario).CodigoCursoSecundario;
        DisciplinaCursoSecundarioNota =
            new Disciplina_CursoSecundarioNota(disciplinaDecimo, disciplinaDecimoPrim, disciplinaDecimoSeg);
        DisciplinaCursoCifDiscDisciplina = new Disciplina_CursoCif(cifDisciplina);
        UtilizadorId = new Identifier(utilizadorId);
        DisciplinaCursoIngresso = new Disciplina_CursoIngresso(isIngresso);
        DisciplinaCursoNotaExameInterno1 = new Disciplina_CursoNotaExameInterno1(notaExameInterno1);
        DisciplinaCursoNotaExameInterno2 = new Disciplina_CursoNotaExameInterno2(notaExameInterno2);
        DisciplinaCursoNotaExameExterno1 = new Disciplina_CursoNotaExameExterno1(notaExameExterno1);
        DisciplinaCursoNotaExameExterno2 = new Disciplina_CursoNotaExameExterno2(notaExameExterno2);
        CodigoExame = new ExameIngressoCodigo(codigoExame).CodigoExameIngresso;
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