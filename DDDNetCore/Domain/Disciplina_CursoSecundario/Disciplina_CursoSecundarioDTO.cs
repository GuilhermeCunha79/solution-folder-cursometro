namespace WebApplication1.Domain.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioDTO
{
    public string Id;
    public string DisciplinaCodigo;
    public int CodigoCursoSecundario;
    public int UtilizadorId;
    public string NotaDecimo;
    public string NotaDecimoPrim;
    public string NotaDecimoSeg;
    public int CifDisciplina;
    public string NotaExame;
    public bool IsIngresso;

    public Disciplina_CursoSecundarioDTO(string id,int utilizadorId,string codigoDisciplina, int codigoCursoSecundario,
        string notaDecimo,string notaDecimoPrim,string notaDecimoSeg, int cifDisciplina, string notaExame, bool isIngresso)
    {
        Id = id;
        UtilizadorId = utilizadorId;
        DisciplinaCodigo = codigoDisciplina;
        CodigoCursoSecundario = codigoCursoSecundario;
        NotaDecimo = notaDecimo;
        NotaDecimoPrim = notaDecimoPrim;
        NotaDecimoSeg = notaDecimoSeg;
        CifDisciplina = cifDisciplina;
        NotaExame = notaExame;
        IsIngresso = isIngresso;
    }
}